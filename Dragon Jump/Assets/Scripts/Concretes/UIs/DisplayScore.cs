using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Game.Concretes.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake() {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        void HandleOnScoreChange(float score){
            _scoreText.text = ((int)score).ToString();
        }

        private void Start() {
            GameManager.Instance.OnScoreChange += HandleOnScoreChange;
        }
        private void OnDisable() {
            GameManager.Instance.OnScoreChange -= HandleOnScoreChange;
        }
    }
}
