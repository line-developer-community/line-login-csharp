using Newtonsoft.Json;

namespace LineDC.Login.Models
{
    /// <summary>
    /// https://developers.line.biz/en/docs/line-login/web/integrate-line-login/#scopes
    /// The following scopes can be specified in the scope parameter. You can specify multiple scopes using the URL encoded whitespace character (%20). You must include at least one scope.
    /// 
    /// profile: Permission to get the user's profile information.
    /// openid: Used to retrieve an ID token.For more information, see ID tokens.
    /// email: Permission to get the user's email address. openid must be specified at the same time. For more information, see ID tokens.
    /// An access token with the profile scope is required to get the friendship status between a user and a bot.
    /// </summary>
    public enum Scope
    {
        /// <summary>
        /// Permission to get the user's profile information.
        /// </summary>
        [JsonProperty("profile")]
        Profile = 0x01,
        /// <summary>
        /// Used to retrieve an ID token.For more information, see ID tokens.
        /// </summary>
        [JsonProperty("openid")]
        OpenId = 0x02,
        /// <summary>
        /// Permission to get the user's email address. openid must be specified at the same time. For more information, see ID tokens.
        /// </summary>
        [JsonProperty("email")]
        Email = 0x04
    }
}