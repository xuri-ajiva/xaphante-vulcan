using System;

namespace SharpVk.Shanq
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LocationAttribute
        : Attribute
    {
        public LocationAttribute(int locationIndex)
        {
            LocationIndex = locationIndex;
        }

        public int LocationIndex
        {
            get;
        }
    }
}