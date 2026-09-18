using System.Runtime.CompilerServices;

namespace ModernEdi;

public static class Pagination
{
    /// <summary>Iterates opaque cursors exactly, with a page bound and cycle detection.</summary>
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
}
