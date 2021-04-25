using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool enemyPool = new EnemyPool(5);
            var enemyAsteroid = enemyPool.GetEnemy("Asteroid");
            enemyAsteroid.transform.position = new Vector3(0, 0, 10);
            enemyAsteroid.gameObject.SetActive(true);
            Enemy.CreateEnemyCylinder(new Health(100.0f, 100.0f));


        }
    }
}