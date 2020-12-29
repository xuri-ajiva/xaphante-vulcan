namespace SharpVk
{
    public partial class PhysicalDevice
    {
        /// <summary>
        ///     Returns properties of available physical device extensions.
        /// </summary>
        public ExtensionProperties[] EnumerateDeviceExtensionProperties()
        {
            return EnumerateDeviceExtensionProperties(null);
        }
    }
}