using SharpVk.Khronos;

namespace vulcan_01
{
    internal struct SwapChainSupportDetails
    {
        public SurfaceCapabilities Capabilities;
        public SurfaceFormat[] Formats;
        public PresentMode[] PresentModes;
    }
}