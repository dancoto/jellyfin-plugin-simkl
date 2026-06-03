using System;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Shoko episode response model.
    /// </summary>
    public class ShokoEpisodeResponse
    {
        /// <summary>
        /// Gets or sets the AniDB data.
        /// </summary>
        [JsonPropertyName("AniDB")]
        public ShokoAniDbData AniDB { get; set; } = new();

        /// <summary>
        /// Gets or sets the IDs.
        /// </summary>
        [JsonPropertyName("IDs")]
        public ShokoIdsData IDs { get; set; } = new();
    }

    /// <summary>
    /// Shoko AniDB data model.
    /// </summary>
    public class ShokoAniDbData
    {
        /// <summary>
        /// Gets or sets the Anime ID.
        /// </summary>
        [JsonPropertyName("AnimeID")]
        public int AnimeID { get; set; }

        /// <summary>
        /// Gets or sets the episode number.
        /// </summary>
        [JsonPropertyName("EpisodeNumber")]
        public int EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of episode.
        /// </summary>
        [JsonPropertyName("Type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// Shoko IDs data model.
    /// </summary>
    public class ShokoIdsData
    {
        /// <summary>
        /// Gets or sets TMDB data.
        /// </summary>
        [JsonPropertyName("TMDB")]
        public ShokoTmdbData TMDB { get; set; } = new();
    }

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
