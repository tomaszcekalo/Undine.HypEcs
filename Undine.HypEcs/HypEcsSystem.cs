
using Undine.Core;
using HypEcs;
using HypEcsISystem = HypEcs.ISystem;

namespace Undine.HypEcs
{
    public class HypEcsSystem<A> : Core.ISystem, HypEcsISystem
         where A : struct
    {
        public UnifiedSystem<A> System { get; set; }
        public World World { get; set; }
        public void ProcessAll()
        {
            Run(World);
        }

        public void Run(World world)
        {
            var query = world.Query<A>().Build();
            query.Run((count, aComponents) =>
            {
                for (var i = 0; i < count; i++)
                {
                    System.ProcessSingleEntity(0, ref aComponents[i]);
                }
            });
        }
    }
    public class HypEcsSystem<A, B> : Core.ISystem, HypEcsISystem
         where A : struct
         where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }
        public World World { get; set; }
        public void ProcessAll()
        {
            Run(World);
        }
        public void Run(World world)
        {
            var query = world.Query<A, B>().Build();
            query.Run((count, aComponents, bComponents) =>
            {
                for (var i = 0; i < count; i++)
                {
                    System.ProcessSingleEntity(0, ref aComponents[i], ref bComponents[i]);
                }
            });
        }
    }
    public class HypEcsSystem<A, B, C> : Core.ISystem, HypEcsISystem
         where A : struct
         where B : struct
         where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }
        public World World { get; set; }
        public void ProcessAll()
        {
            Run(World);
        }
        public void Run(World world)
        {
            var query = world.Query<A, B, C>().Build();
            query.Run((count, aComponents, bComponents, cComponents) =>
            {
                for (var i = 0; i < count; i++)
                {
                    System.ProcessSingleEntity(0, ref aComponents[i], ref bComponents[i], ref cComponents[i]);
                }
            });
        }
    }
    public class HypEcsSystem<A, B, C, D> : Core.ISystem, HypEcsISystem
         where A : struct
         where B : struct
         where C : struct
         where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }
        public World World { get; set; }
        public void ProcessAll()
        {
            Run(World);
        }
        public void Run(World world)
        {
            var query = world.Query<A, B, C, D>().Build();
            query.Run((count, aComponents, bComponents, cComponents, dComponents) =>
            {
                for (var i = 0; i < count; i++)
                {
                    System.ProcessSingleEntity(0, ref aComponents[i], ref bComponents[i], ref cComponents[i], ref dComponents[i]);
                }
            });
        }
    }
}
