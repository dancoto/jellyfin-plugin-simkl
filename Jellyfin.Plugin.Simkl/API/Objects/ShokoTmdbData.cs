using System;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Shoko TMDB data model.
    /// </summary>
    public class ShokoTmdbData
    {
        /// <summary>
        /// Gets or sets the movie IDs.
        /// </summary>
        [JsonPropertyName("Movie")]
        public int[] Movie { get; set; } = Array.Empty<int>();
    }
}
