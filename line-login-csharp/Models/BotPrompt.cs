namespace LineDC.Login.Models
{
    /// <summary>
    /// https://developers.line.biz/en/docs/line-login/web/link-a-bot/
    /// Displaying the option to add your bot as friend
    /// </summary>
    public enum BotPrompt
    {
        /// <summary>
        /// Includes an option to add a bot as friend in the consent screen.
        /// </summary>
        Normal,
        /// <summary>
        /// Opens a new screen to add the bot as friend after the user agrees to the permissions in the consent screen.
        /// </summary>
        Aggresive
    }
}