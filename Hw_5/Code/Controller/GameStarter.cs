using UnityEngine;
using Asteroids.Prototype;
using System;
namespace Asteroids
{
    [Serializable]
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = new Vector3(1,7,0);
            enemy.gameObject.SetActive(true);
           


            


        }
    }
}