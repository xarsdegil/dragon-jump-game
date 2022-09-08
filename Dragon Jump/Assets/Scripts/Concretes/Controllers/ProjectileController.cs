using System.Collections;
using System.Collections.Generic;
using Game.Abstracts.Controllers;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void Awake() {
            var audioSource = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(audioSource.clip, this.transform.position);
        }
        private void OnTriggerEnter2D(Collider2D other) {
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            if(enemy != null && enemy.gameObject.name.Contains("RedDragon")){
                enemy.KillGameObject();
                GameManager.Instance.IncreaseScore(2f);
            }
            KillGameObject();
        }
        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }
    }

}