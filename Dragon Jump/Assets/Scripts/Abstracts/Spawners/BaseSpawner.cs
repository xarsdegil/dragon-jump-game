using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(1f,10f)]
        [SerializeField] float maxSpawntime = 3f, minSpawnTime = 1f;
        float _currentSpawnTime, _timeBoundary;

        private void Start() {
            ResetTime();
        }

        private void Update() {
            _currentSpawnTime += Time.deltaTime;
            if(_currentSpawnTime > _timeBoundary){
                Spawn();
                ResetTime();
            }
        }

        protected abstract void Spawn();

        void ResetTime(){
            _timeBoundary = Random.Range(minSpawnTime, maxSpawntime);
            _currentSpawnTime = 0f;
        }
    }
}
