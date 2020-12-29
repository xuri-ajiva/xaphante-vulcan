using SharpVk.Interop;
using SharpVk.Multivendor;

namespace SharpVk
{
    partial class Instance
    {
        /// <summary>
        ///     Create a new Vulkan instance.
        /// </summary>
        /// <param name="flags">
        ///     Reserved for future use.
        /// </param>
        /// <param name="applicationInfo">
        ///     Null or an instance of ApplicationInfo. If not Null, this
        ///     information helps implementations recognize behavior inherent to
        ///     classes of applications. ApplicationInfo is defined in detail
        ///     below.
        /// </param>
        /// <param name="enabledLayerNames">
        ///     An array of enabledLayerCount strings containing the names of
        ///     layers to enable for the created instance. See the Layers section
        ///     for further details.
        /// </param>
        /// <param name="enabledExtensionNames">
        ///     An array of enabledExtensionCount strings containing the names of
        ///     extensions to enable.
        /// </param>
        /// <param name="debugReportCallbackCreateInfoExt">
        /// </param>
        /// <param name="validationFlagsExt">
        /// </param>
        /// <param name="debugUtilsMessengerCreateInfoExt">
        /// </param>
        /// <param name="allocator">
        ///     An optional AllocationCallbacks instance that controls host memory
        ///     allocation.
        /// </param>
        public static Instance Create(ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, InstanceCreateFlags? flags = default, ApplicationInfo? applicationInfo = default, DebugReportCallbackCreateInfo? debugReportCallbackCreateInfoExt = null, ValidationFlags? validationFlagsExt = null, ValidationFeatures? validationFeaturesExt = null, DebugUtilsMessengerCreateInfo? debugUtilsMessengerCreateInfoExt = null, AllocationCallbacks? allocator = null)
        {
            var cache = new CommandCache(new NativeLibrary());
            cache.Initialise();

            return Create(cache, enabledLayerNames, enabledExtensionNames, flags, applicationInfo, debugReportCallbackCreateInfoExt, validationFlagsExt, validationFeaturesExt, debugUtilsMessengerCreateInfoExt, allocator);
        }

        /// <summary>
        ///     Returns up to requested number of global extension properties.
        /// </summary>
        public static ExtensionProperties[] EnumerateExtensionProperties(string layerName = null)
        {
            var cache = new CommandCache(new NativeLibrary());
            cache.Initialise();

            return EnumerateExtensionProperties(cache, layerName);
        }

        /// <summary>
        ///     Returns up to requested number of global extension properties.
        /// </summary>
        public static Version EnumerateVersion()
        {
            var commandCache = new CommandCache(new NativeLibrary());

            commandCache.Initialise();

            if (commandCache.IsCommandAvailable("vkEnumerateInstanceVersion", ""))
                return EnumerateVersion(commandCache);
            return new(1, 0, 0);
        }

        /// <summary>
        ///     Returns up to requested number of global layer properties.
        /// </summary>
        public static LayerProperties[] EnumerateLayerProperties()
        {
            var cache = new CommandCache(new NativeLibrary());
            cache.Initialise();

            return EnumerateLayerProperties(cache);
        }
    }
}