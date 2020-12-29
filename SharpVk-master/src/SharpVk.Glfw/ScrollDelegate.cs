namespace SharpVk.Glfw
{
    /// <summary>
    ///     The function signature for scroll callback functions.
    /// </summary>
    /// <param name="window">
    ///     The window that received the event.
    /// </param>
    /// <param name="xOffset">
    ///     The scroll offset along the x-axis.
    /// </param>
    /// <param name="yOffset">
    ///     The scroll offset along the y-axis.
    /// </param>
    public delegate void ScrollDelegate(WindowHandle window, double xOffset, double yOffset);
}