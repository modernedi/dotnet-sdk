// Generated from the ModernEDI Integration API 1.35.0. Do not edit.
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using ModernEdi;

namespace ModernEdi.Model;

/// <summary></summary>

public sealed class ConfigurationExternalRepository
{
    /// <summary>Canonical HTTPS repository URL without credentials.</summary>
    [JsonPropertyName("repositoryUrl")]
    [JsonRequired]
    public string RepositoryUrl { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("branch")]
    [JsonRequired]
    public string Branch { get; set; } = default!;

    /// <summary>Bundle directory within the connected repository.</summary>
    [JsonPropertyName("directory")]
    [JsonRequired]
    public string Directory { get; set; } = default!;

    /// <summary>Current synchronization state. Held means import tests have not authorized an import; conflict means both sides changed and an owner must review.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public string Status { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("automatic")]
    [JsonRequired]
    public bool Automatic { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("verifyBeforeImport")]
    [JsonRequired]
    public bool VerifyBeforeImport { get; set; } = default!;

    /// <summary>Connection status revision; polling may advance it without a configuration change.</summary>
    [JsonPropertyName("revision")]
    [JsonRequired]
    public long Revision { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public string CreatedAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    [JsonRequired]
    public string UpdatedAt { get; set; } = default!;

    /// <summary>Scheduled check or retry time; not a completion promise.</summary>
    [JsonPropertyName("nextAttemptAt")]
    [JsonRequired]
    public string NextAttemptAt { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("importVerification")]
    [JsonRequired]
    public ConfigurationExternalRepositoryImportVerification? ImportVerification { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("lastSyncedAt")]
    [JsonRequired]
    public string? LastSyncedAt { get; set; } = default!;

    /// <summary>Last synchronized internal workspace Git commit.</summary>
    [JsonPropertyName("workspaceCommitSha")]
    [JsonRequired]
    public string? WorkspaceCommitSha { get; set; } = default!;

    /// <summary>Last synchronized external commit; may differ from the remote branch&#39;s current HEAD.</summary>
    [JsonPropertyName("repositoryCommitSha")]
    [JsonRequired]
    public string? RepositoryCommitSha { get; set; } = default!;

    /// <summary></summary>
    [JsonPropertyName("lastError")]
    [JsonRequired]
    public ConfigurationExternalRepositoryLastError? LastError { get; set; } = default!;

    /// <summary>Unrecognized response fields, preserved on re-serialization.</summary>
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
