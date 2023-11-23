using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject _gameovercanvas;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }   

    public void GameOver()
    {
        _gameovercanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;

    }
}
