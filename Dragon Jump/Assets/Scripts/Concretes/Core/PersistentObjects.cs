using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Core
{
    public class PersistentObjects : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;
        static bool _isFirstTime = true;

        private void Start() {
            if(_isFirstTime){
                SpawnPersistentObjects();
                _isFirstTime = false;
            }
        }

        private void SpawnPersistentObjects()
        {
            var newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}
