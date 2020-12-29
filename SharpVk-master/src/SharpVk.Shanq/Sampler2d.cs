namespace SharpVk.Shanq
{
    public abstract class Sampler2d<T, V>
    {
        public abstract T Sample(V coords);
    }
}