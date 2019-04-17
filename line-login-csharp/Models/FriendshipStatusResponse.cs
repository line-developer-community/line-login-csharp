using Newtonsoft.Json;

namespace LineDC.Login.Models
{
    /// <summary>
    /// https://developers.line.biz/en/reference/social-api/#get-friendship-status
    /// Response of gets the friendship status of the user and the bot linked to your LINE Login channel.
    /// </summary>
    public class FriendshipStatusResponse
    {
        /// <summary>
        /// true if the user has added the bot as a friend and has not blocked the bot. Otherwise, false.
        /// </summary>
        [JsonProperty("friendFlag")]
        public bool FriendFlag { get; set; }        
    }
}