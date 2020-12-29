using System;
using System.Collections.Generic;

namespace SharpVk.Glfw
{
    /// <summary>
    ///     Represents an instance of a GLFW3 Window.
    /// </summary>
    public class Window
        : IDisposable
    {
        internal readonly WindowHandle handle;

        private bool isDisposed;

        /// <summary>
        ///     Creates a window and its associated OpenGL or OpenGL ES context.
        /// </summary>
        /// <param name="width">
        ///     The desired width, in screen coordinates, of the window. This must
        ///     be greater than zero.
        /// </param>
        /// <param name="height">
        ///     The desired height, in screen coordinates, of the window. This must
        ///     be greater than zero.
        /// </param>
        /// <param name="title">
        ///     The initial window title.
        /// </param>
        /// <param name="windowHints">
        ///     A dictionary of hints to set before creating the window.
        /// </param>
        public Window(int width, int height, string title, Dictionary<WindowAttribute, int> windowHints = null)
            : this(width, height, title, MonitorHandle.Zero, windowHints)
        {
        }

        internal Window(int width, int height, string title, MonitorHandle monitor, Dictionary<WindowAttribute, int> windowHints)
        {
            try
            {
                ErrorUtility.Bind();

                if (windowHints != null)
                    foreach (var hintPair in windowHints)
                        Glfw3.WindowHint(hintPair.Key, hintPair.Value);

                handle = Glfw3.CreateWindow(width, height, title, monitor, WindowHandle.Zero);

                ErrorUtility.ThrowOnError();
            }
            finally
            {
                ErrorUtility.Unbind();
            }
        }

        /// <summary>
        ///     Returns the value of the close flag for this window.
        /// </summary>
        public bool ShouldClose
        {
            get
            {
                ThrowOnDisposed();

                return Glfw3.WindowShouldClose(handle);
            }
        }

        public WindowHandle Handle => handle;

        /// <summary>
        ///     Releases all unmanaged resources associated with this window.
        /// </summary>
        public void Dispose()
        {
            Close();
        }

        public InputAction GetKeyState(Key key)
        {
            try
            {
                ErrorUtility.Bind();

                var result = Glfw3.GetKey(handle, key);

                ErrorUtility.ThrowOnError();

                return result;
            }
            finally
            {
                ErrorUtility.Unbind();
            }
        }

        public InputAction GetMouseButtonState(MouseButton mouseButton)
        {
            try
            {
                ErrorUtility.Bind();

                var result = Glfw3.GetMouseButton(handle, mouseButton);

                ErrorUtility.ThrowOnError();

                return result;
            }
            finally
            {
                ErrorUtility.Unbind();
            }
        }

        private void ThrowOnDisposed()
        {
            if (isDisposed) throw new ObjectDisposedException(ToString());
        }

        /// <summary>
        ///     Closes the window.
        /// </summary>
        public void Close()
        {
            if (!isDisposed)
                try
                {
                    ErrorUtility.Bind();

                    Glfw3.DestroyWindow(handle);

                    isDisposed = true;

                    ErrorUtility.ThrowOnError();
                }
                finally
                {
                    ErrorUtility.Unbind();
                }
        }
    }
}
