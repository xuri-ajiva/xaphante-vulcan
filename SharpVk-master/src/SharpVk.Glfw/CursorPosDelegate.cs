namespace SharpVk.Glfw
{
    /// <summary>
    ///     The function signature for cursor position callback functions.
    /// </summary>
    /// <param name="window">
    ///     The window that received the event.
    /// </param>
    /// <param name="xPosition">
    ///     The new cursor x-coordinate, relative to the left edge of the client area.
    /// </param>
    /// <param name="yPosition">
    ///     The new cursor y-coordinate, relative to the top edge of the client area.
    /// </param>
    public delegate void CursorPosDelegate(WindowHandle window, double xPosition, double yPosition);
}