using System;
using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Combat;
using Game.Concretes.Controllers;
using Game.Concretes.Pools;
using UnityEngine;

namespace Game.Concretes.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        private void Start() {
            Death death = FindObjectOfType<Death>();
            death.OnDeath += HandleOnDeath;
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
            HighScoreController.Instance.SetHighScore(GameManager.Instance.Score);
        }
    }
}
