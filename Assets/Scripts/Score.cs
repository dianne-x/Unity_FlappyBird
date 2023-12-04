using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _bestscore;

    private int _score = 0;
    private int _bestscoreInt = 0;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _currentScore.text = _score.ToString();
        _bestscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }


    public void ScoreUpdate()
    {
        _score++;
        _currentScore.text = _score.ToString();
        if (_score > PlayerPrefs.GetInt("HighScore", _bestscoreInt))
        {
            _bestscoreInt = _score;
            _bestscore.text = _bestscoreInt.ToString();
            PlayerPrefs.SetInt("HighScore", _bestscoreInt);

        }
    }

    void Update()
    {
        
    }







}
