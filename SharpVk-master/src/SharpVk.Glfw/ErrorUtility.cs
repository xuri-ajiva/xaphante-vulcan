using System;

namespace SharpVk.Glfw
{
    internal static class ErrorUtility
    {
        [ThreadStatic] private static ErrorDelegate wrappedDelegate;

        [ThreadStatic] private static ErrorDelegate callback;

        [field: ThreadStatic]
        public static ErrorCode? Code { get; private set; }

        [field: ThreadStatic]
        public static string Description { get; private set; }

        public static void Bind()
        {
            Code = null;
            Description = null;

            if (callback == null)
                callback = (errorCode, errorDescription) =>
                {
                    Code = errorCode;
                    Description = errorDescription;

                    wrappedDelegate?.Invoke(errorCode, errorDescription);
                };

            wrappedDelegate = Glfw3.SetErrorCallback(callback);
        }

        public static void ThrowOnError()
        {
            if (Code.HasValue) throw new GlfwErrorException(Code.Value, Description);
        }

        public static void Unbind()
        {
            Glfw3.SetErrorCallback(wrappedDelegate);
        }
    }
}