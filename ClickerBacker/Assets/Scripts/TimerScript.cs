using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timeBar;
    [SerializeField] private float _maxTime;
    private float _timeLeft;
    private void Start()
    {
        _timeLeft = _maxTime;
    }
    void Update()
    {
        Timer();
    }
    private void Timer()
    {
        if(_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _timeBar.fillAmount = _timeLeft / _maxTime;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
