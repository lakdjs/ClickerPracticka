using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingGame : MonoBehaviour
{
    [SerializeField] private string _plotScene;
    [SerializeField] private string _gameScene;
    [SerializeField] private Button _startButton;
    private void Start()
    {
        _startButton.onClick.AddListener(StartGame);
    }
    private void StartGame()
    {
        if(PlayerPrefs.GetInt("IsGameStarted")==1)
        {
            SceneManager.LoadScene(_gameScene);
        }
        else
        {
            PlayerPrefs.SetInt("IsGameStarted",1);
            SceneManager.LoadScene(_plotScene);
        }
    }
}
