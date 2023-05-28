using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timeBar;
    private int _maxTime;
    private float _timeLeft;
    private void Start()
    {
        _maxTime = GetComponent<Orders.OrderScript>().Time;
        _timeLeft = _maxTime;
    }
    void Update()
    {
        
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
