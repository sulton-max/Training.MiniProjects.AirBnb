﻿namespace AirBnb.Infrastructure.StorageFiles.Settings;

/// <summary>
/// Represents the settings for storage files.
/// </summary>
public class StorageFileSettings
{
    /// <summary>
    /// Gets the location settings for storage files.
    /// </summary>
    public IEnumerable<StorageFileLocationSettings> LocationSettings { get; init; } = default!;
}