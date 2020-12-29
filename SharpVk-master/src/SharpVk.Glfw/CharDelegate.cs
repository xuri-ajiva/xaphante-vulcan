namespace SharpVk.Glfw
{
    /// <summary>
    ///     A delegate representing character events on a WindowHandle.
    /// </summary>
    /// <param name="window">
    ///     The window raising the event.
    /// </param>
    /// <param name="codepoint">
    ///     The Unicode codepoint of the character.
    /// </param>
    public delegate void CharDelegate(WindowHandle window, CodePoint codepoint);
}