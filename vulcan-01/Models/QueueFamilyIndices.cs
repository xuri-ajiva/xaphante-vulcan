using System.Collections.Generic;

namespace vulcan_01
{
    internal struct QueueFamilyIndices
    {
        public uint? GraphicsFamily;
        public uint? PresentFamily;
        public uint? TransferFamily;

        public IEnumerable<uint> Indices
        {
            get
            {
                if (GraphicsFamily.HasValue)
                {
                    yield return GraphicsFamily.Value;
                }

                if (PresentFamily.HasValue && PresentFamily != GraphicsFamily)
                {
                    yield return PresentFamily.Value;
                }

                if (TransferFamily.HasValue && TransferFamily != PresentFamily && TransferFamily != GraphicsFamily)
                {
                    yield return TransferFamily.Value;
                }
            }
        }

        public bool IsComplete =>
            GraphicsFamily.HasValue
            && PresentFamily.HasValue
            && TransferFamily.HasValue;
    }
}