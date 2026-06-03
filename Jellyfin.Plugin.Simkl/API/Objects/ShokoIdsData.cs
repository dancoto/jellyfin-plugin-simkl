using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Simkl.API.Objects
{
    /// <summary>
    /// Shoko IDs data model.
    /// </summary>
    public class ShokoIdsData
    {
        /// <summary>
        /// Gets or sets TMDB data.
        /// </summary>
        [JsonPropertyName("TMDB")]
        public ShokoTmdbData TMDB { get; set; } = new ShokoTmdbData();
    }
}
