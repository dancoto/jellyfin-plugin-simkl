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
        public ShokoAniDbData AniDB { get; set; } = new ShokoAniDbData();

        /// <summary>
        /// Gets or sets the IDs.
        /// </summary>
        [JsonPropertyName("IDs")]
        public ShokoIdsData IDs { get; set; } = new ShokoIdsData();
    }
}
