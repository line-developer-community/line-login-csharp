using Newtonsoft.Json;

namespace LineDC.Login.Models
{
    /// <summary>
    /// https://developers.line.biz/en/reference/social-api/#get-user-profile
    /// </summary>
    public class Profile
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("pictureUrl")]
        public string PictureUrl { get; set; }
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }
    }
}