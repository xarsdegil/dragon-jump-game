using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float _maxLifeTime = 5f;
        protected float _currentTime;

        private void Update() {
            _currentTime += Time.deltaTime;
            if(_currentTime > _maxLifeTime){
                KillGameObject();
            }
        }

        public abstract void KillGameObject();
    }
}
