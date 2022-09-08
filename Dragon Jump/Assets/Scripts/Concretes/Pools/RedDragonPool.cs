using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Pools;
using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Pools
{
    public class RedDragonPool : GenericPool<RedDragonController>
    {
        public static RedDragonPool Instance { get; private set; }

        private void Awake() {
            SingletonObject();
        }
        
        protected override void SingletonObject()
        {
            if(Instance == null){
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }else{
                Destroy(this.gameObject);
            }
        }

        public override void ResetAllObjects()
        {
            foreach (var child in transform.GetComponentsInChildren<RedDragonController>())
            {
                if(!child.gameObject.activeSelf){
                    continue;
                }
                child.KillGameObject();
            }
        }
    }
}
