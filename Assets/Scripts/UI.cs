using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI instance;
    int score=0;
    [SerializeField] private TextMeshPro scoreText;
    public GameObject levelComplete;
    public Button play;
    public Button quit;
    public Button restart;    
    public Button restart2;
    public bool finish = false;


    private void Awake()
    {
        instance = this;
    }
  
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
    public void WinPanel()
    {
        finish = true;
        levelComplete.gameObject.SetActive(true);
        
    }
    public void WinPanelButton()
    {
        restart.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
    }
    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);

    }
    public void PauseButton()
    {
        play.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
        restart2.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Play()
    {
        play.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        restart2.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        restart.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
    }
  
    public void PlayerDead()
    {
        Time.timeScale = 0;
        restart.gameObject.SetActive(true);        
        quit.gameObject.SetActive(true);


    }
}
