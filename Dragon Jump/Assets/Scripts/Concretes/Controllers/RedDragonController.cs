using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class RedDragonController : EnemyController
    {

        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}
