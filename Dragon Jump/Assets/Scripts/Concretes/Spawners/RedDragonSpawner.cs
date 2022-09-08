using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Spawners;
using Game.Concretes.Controllers;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);
        }
    }
}
