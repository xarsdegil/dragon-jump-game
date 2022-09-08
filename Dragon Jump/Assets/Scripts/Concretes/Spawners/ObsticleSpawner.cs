using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Spawners;
using Game.Concretes.Controllers;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController poolObject = ObsticlePool.Instance.Get();
            poolObject.transform.position = this.transform.position;
            poolObject.gameObject.SetActive(true);
        }
    }
}
