using System.Runtime.CompilerServices;
using ModernEdi.Model;

namespace ModernEdi;

public static class Pagination
{
    /// <summary>Iterates read-only lists, with a page bound and cycle detection. Use MappedOutputsAsync for queue polls.</summary>
    public static async IAsyncEnumerable<TItem> CursorAsync<TPage, TItem>(
        Func<string?, CancellationToken, Task<TPage>> load, Func<TPage, IEnumerable<TItem>> items,
        Func<TPage, string?> nextCursor, string? cursor = null, int maxPages = 1000,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (maxPages < 1) throw new ArgumentOutOfRangeException(nameof(maxPages));
        var seen = new HashSet<string>(StringComparer.Ordinal);
        for (var pageNumber = 0; pageNumber < maxPages; pageNumber++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (cursor is not null && !seen.Add(cursor)) throw new InvalidOperationException("Repeated pagination cursor.");
            var page = await load(cursor, cancellationToken).ConfigureAwait(false);
            foreach (var item in items(page)) { cancellationToken.ThrowIfCancellationRequested(); yield return item; }
            cursor = nextCursor(page);
            if (cursor is null) yield break;
        }
    }

    /// <summary>Bounded queue scan; repeated cursors are valid because leases advance the queue.
    /// Persist and acknowledge each output yourself. Does not retry failed polls, acknowledge,
    /// deduplicate redeliveries, or continuously watch.</summary>
    public static async IAsyncEnumerable<MappedOutputMessage> MappedOutputsAsync(
        Func<string?, CancellationToken, Task<ApiResponse<MappedOutputQueueResponse>>> load,
        string? cursor = null, int maxPolls = 1000,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (maxPolls < 1) throw new ArgumentOutOfRangeException(nameof(maxPolls));
        for (var poll = 0; poll < maxPolls; poll++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var page = (await load(cursor, cancellationToken).ConfigureAwait(false)).Data
                ?? throw new InvalidOperationException("Mapped-output poll returned no body.");
            foreach (var item in page.Messages) { cancellationToken.ThrowIfCancellationRequested(); yield return item; }
            cursor = page.NextCursor;
            if (cursor is null) yield break;
        }
    }
}
