namespace SharpVk.Glfw
{
    /// <summary>
    ///     The function signature for mouse button callback functions.
    /// </summary>
    /// <param name="window">
    ///     The window that received the event.
    /// </param>
    /// <param name="button">
    ///     The mouse button that was pressed or released.
    /// </param>
    /// <param name="action">
    ///     One of <see cref="InputAction.Press" /> or <see cref="InputAction.Release" />.
    /// </param>
    /// <param name="mods">
    ///     Bit field describing which modifier keys were held down.
    /// </param>
    public delegate void MouseButtonDelegate(WindowHandle window, MouseButton button, InputAction action, Modifier mods);
}