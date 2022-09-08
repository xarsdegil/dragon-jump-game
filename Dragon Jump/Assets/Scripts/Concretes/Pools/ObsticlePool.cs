using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Pools;
using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Pools
{

    public class ObsticlePool : GenericPool<ObsticleController>
    {
        public static ObsticlePool Instance { get; private set; }

        public override void ResetAllObjects()
        {
            foreach (var child in transform.GetComponentsInChildren<ObsticleController>())
            {
                if(!child.gameObject.activeSelf){
                    continue;
                }
                child.KillGameObject();
            }
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
    }
}