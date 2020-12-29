namespace SharpVk.Glfw
{
    /// <summary>
    ///     A delegate representing character events with modifiers on a WindowHandle.
    /// </summary>
    /// <param name="window">
    ///     The window raising the event.
    /// </param>
    /// <param name="codepoint">
    ///     The Unicode codepoint of the character.
    /// </param>
    /// <param name="modifiers">
    ///     The modifiers applied to the character.
    /// </param>
    public delegate void CharModsDelegate(WindowHandle window, CodePoint codepoint, Modifier modifiers);
}