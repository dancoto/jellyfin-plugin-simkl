using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
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
}
