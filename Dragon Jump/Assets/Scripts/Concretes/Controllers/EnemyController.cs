using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Controllers;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}