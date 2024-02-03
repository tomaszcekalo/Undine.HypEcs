using HypEcs;
using Undine.Core;

namespace Undine.HypEcs
{
    public class HypEcsEntity : IUnifiedEntity
    {
        public EntityBuilder EntityBuilder { get; set; }
        public World World { get; set; }
        public void AddComponent<A>(in A component) where A : struct
        {
            EntityBuilder.Add(component);
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref World.GetComponent<A>(EntityBuilder.Id());
            //throw new NotImplementedException();
        }

        public void RemoveComponent<A>() where A : struct
        {
            EntityBuilder.Remove<A>();
        }

        public bool HasComponent<A>() where A : struct
        {
            return World.HasComponent<A>(this.EntityBuilder.Id());
        }
    }
}
