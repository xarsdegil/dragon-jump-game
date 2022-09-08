using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class HighScoreController : MonoBehaviour
    {
        public static int CurrentHighScore { get; private set; }
        public static HighScoreController Instance { get; private set; }

        private void Start() {
            SingletonThisGameObject();
            CurrentHighScore = PlayerPrefs.GetInt("highscore");
        }

        public void SetHighScore(int score){
            if(score > CurrentHighScore){
                PlayerPrefs.SetInt("highscore", score);
                CurrentHighScore = score;
            }
        }
         private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }


    }
}
