using System;
using System.Threading.Tasks;

namespace vulcan_01
{
    internal partial class Program
    {
        private readonly Vertex[] vertices = new Vertex[10];
        private readonly ushort[] indices = new ushort[30];
        
        //
        //private readonly ushort[] indices =
        //{
        //    0, 1, 2, 2, 3, 0,
        //};
        //private readonly Vertex[] vertices = new[]
        //{
        //    new Vertex(new vec2(-0.5f, -0.5f), new(1.0f, 0.0f, 0.0f), new(1.0f, 0.0f)),
        //    new Vertex(new vec2(0.5f, -0.5f), new(0.0f, 1.0f, 0.0f), new(0.0f, 0.0f)), 
        //    new Vertex(new vec2(0.5f, 0.5f), new(0.0f, 0.0f, 1.0f), new(0.0f, 1.0f)),
        //    new Vertex(new vec2(-0.5f, 0.5f), new(1.0f, 1.0f, 1.0f), new(1.0f, 1.0f))
        //};
        //private readonly Vertex[] vertices =
        //{
        //    new(new(-0.5f, -0.5f, -.5f), new(1.0f, 0.0f, 0.0f)), new(new(0.5f, -0.5f, .5f), new(0.0f, 1.0f, 0.0f)), new(new(0.5f, 0.5f, -.5f), new(0.0f, 0.0f, 1.0f)), new(new(-0.5f, 0.5f, .5f), new(1.0f, 1.0f, 1.0f)),
        //};

        public async Task AwaitResult(Task<State> task, string name = "unknown")
        {
            var res = await task;
            if (res != State.Ok)
            {
                Console.WriteLine($"Task {name} returned {res}!");
                // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
                switch (res)
                {
                    case State.RequestExit:
                        await Task.Delay(3000);
                        Environment.Exit((int)res);
                        break;
                    default:
                        break;
                }
            }
        }

        private static Task<State> Ok()
        {
            return Task.FromResult(State.Ok);
        }

        public static async void Await(Task<State> task)
        {
            await task;
        }
    }

    internal enum State : int
    {
        Ok = 0,
        RequestExit = 1,
        Error = -1,
        Fail = -2,
        UserError = 2,
    }
}
