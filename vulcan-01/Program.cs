namespace vulcan_01
{
    internal partial class Program
    {
        private readonly Vertex[] vertices =
        {
            new(new(-0.5f, -0.5f), new(1.0f, 0.0f, 0.0f)), new(new(0.5f, -0.5f), new(0.0f, 1.0f, 0.0f)), new(new(0.5f, 0.5f), new(0.0f, 0.0f, 1.0f)), new(new(-0.5f, 0.5f), new(1.0f, 1.0f, 1.0f))
        };

        private readonly ushort[] indices =
        {
            0, 1, 2, 2, 3, 0
        };
    }
}
