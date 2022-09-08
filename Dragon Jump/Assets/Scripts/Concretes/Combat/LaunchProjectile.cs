using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Concretes.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] float delayProjectile;
        float _currentDelayTime;
        bool _canLaunch;


        private void Update() {
            SetDelay();
        }

        public void LaunchAction(){
            if(_canLaunch){
                Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.rotation);
                _canLaunch = false;
            }
            
        }

        void SetDelay(){
            _currentDelayTime += Time.deltaTime;
            if(_currentDelayTime > delayProjectile){
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }
    }
}
