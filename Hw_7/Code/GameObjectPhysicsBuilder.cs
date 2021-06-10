using UnityEngine;

namespace Asteroids
{
    
    internal sealed class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject) { }

        public GameObjectPhysicsBuilder BoxCollider2D(bool triger)
        {
           var component =  GetOrAddComponent<BoxCollider2D>();
            component.isTrigger = true;
            return this;
        }

        public GameObjectPhysicsBuilder Rigidbody2D(float mass, float gravity)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            component.gravityScale = gravity;
            return this;
        }
        

        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}