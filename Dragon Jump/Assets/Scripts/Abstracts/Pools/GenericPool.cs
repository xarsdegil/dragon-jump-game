using System;
using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Combat;
using UnityEngine;

namespace Game.Abstracts.Pools
{
    public abstract class GenericPool<T> : MonoBehaviour where T : Component
    {
        [SerializeField] T[] prefabs;
        [SerializeField] int countLoop = 5;

        protected Queue<T> _poolPrefabs = new Queue<T>();

        private void Awake() {
            SingletonObject();
        }

        private void Start() {
            GrowPool();
        }

        private void OnEnable() {
            GameManager.Instance.OnSceneChange += ResetAllObjects;
        }

        private void OnDisable() {
            GameManager.Instance.OnSceneChange -= ResetAllObjects;
        }

        protected abstract void SingletonObject();

        public T Get(){
            if(_poolPrefabs.Count == 0){
                GrowPool();
            }
            return _poolPrefabs.Dequeue();
        }

        private void GrowPool()
        {
            for (int i = 0; i < countLoop; i++)
            {
                T newPrefab = Instantiate(prefabs[UnityEngine.Random.Range(0, prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }
        }

        public void Set(T poolObject){
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }

        public abstract void ResetAllObjects();

        
    }
}
