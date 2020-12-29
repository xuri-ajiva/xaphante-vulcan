namespace SharpVk.Generator.Rules
{
    public interface IRule<in T>
    {
        bool Apply(T arg);
    }

    public interface IRule<in T, in U>
    {
        bool Apply(T arg1, U arg2);
    }

    public interface IRule<in T, in U, in V>
    {
        bool Apply(T arg1, U arg2, V arg3);
    }

    public interface IRule<in T, in U, in V, in W>
    {
        bool Apply(T arg1, U arg2, V arg3, W arg4);
    }

    public interface IFuncRule<in T, U>
    {
        bool Apply(T arg, out U result);
    }

    public interface IFuncRule<in T, in U, V>
    {
        bool Apply(T arg1, U arg2, out V result);
    }

    public interface IFuncRule<in T, in U, in V, W>
    {
        bool Apply(T arg1, U arg2, V arg3, out W result);
    }
}
