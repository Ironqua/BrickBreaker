using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject _gamePanel;
    public Text _scoreText;
    public int score;
    private int currentBrickCount;

    private void Awake()
    {

        Singleton();
        DontDestroyOnLoad(gameObject);
    }

    private void Singleton()
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
    public void UpdateBrickCount(int changeAmount)
    {
        currentBrickCount += changeAmount;
    }

    public int GetCurrentBrickCount()
    {
        return currentBrickCount;
    }

    public void ActivePanel()
    {
        _gamePanel.SetActive(true); 
    }

    public void Score()
    {
        score++;
        _scoreText.text=score.ToString();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Destroy(GameManager.Instance.gameObject); 
        GameManager.Instance = null; 
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Destroy(GameManager.Instance.gameObject); 
        GameManager.Instance = null; 
    }

}
