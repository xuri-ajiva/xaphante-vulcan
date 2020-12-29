namespace SharpVk.Shanq
{
    public abstract class Sampler2d<T, TV>
    {
        public abstract T Sample(TV coords);
    }
}
