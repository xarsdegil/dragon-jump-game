using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Controllers;
using TMPro;
using UnityEngine;

namespace Game.Concretes.UIs
{
    public class MenuCanvas : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _highScoreText;

        private void Start() {
            _highScoreText.text = "High Score: " + HighScoreController.CurrentHighScore.ToString();
        }

        public void ExitButtonClick(){
            GameManager.Instance.ExitGame();
        }

        public void PlayButtonClick(){
            GameManager.Instance.StartGame();
        }
    }
}
