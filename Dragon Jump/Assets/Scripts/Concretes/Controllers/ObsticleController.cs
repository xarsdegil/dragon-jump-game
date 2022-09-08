using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class ObsticleController : EnemyController
    {

        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);
        }
    }
}
