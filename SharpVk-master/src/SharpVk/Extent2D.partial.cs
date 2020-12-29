namespace SharpVk
{
    public partial struct Extent2D
    {
        /// <summary>
        /// </summary>
        public float AspectRatio => Width / (float)Height;
    }
}