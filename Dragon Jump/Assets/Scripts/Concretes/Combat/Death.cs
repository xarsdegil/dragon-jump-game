using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Combat
{
    public class Death : MonoBehaviour
    {
        public bool IsDead { get; private set; }
        public event System.Action OnDeath;

        private void OnCollisionEnter2D(Collision2D other) {
            Time.timeScale = 0f;
            IsDead = true;
            OnDeath?.Invoke(); 
        }
    }
}
