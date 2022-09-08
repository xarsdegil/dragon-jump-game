using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float score;
    public int Score { get{ return (int)score; } private set{} }
    public static GameManager Instance { get; private set; }

    public event System.Action<float> OnScoreChange;
    public event System.Action OnSceneChange;

    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void Update() {
        IncreaseScore(Time.deltaTime);
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

    public void StartGame(){
        StartCoroutine(StartGameAsync());
        Time.timeScale = 1f;
        score = 0f;
        OnSceneChange?.Invoke();
    }

    public void ReturnMenu(){
        StartCoroutine(ReturnMenuAsync());
        OnSceneChange?.Invoke();
    }

    private IEnumerator ReturnMenuAsync(){
        yield return SceneManager.LoadSceneAsync("Menu");
    }

    private IEnumerator StartGameAsync(){
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void IncreaseScore(float value){
        score += value;
        OnScoreChange?.Invoke(score);
    }

    public void ExitGame(){
        Application.Quit();
    }

}
