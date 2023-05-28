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
    public void Start()
    {
    }
    void Update()
    {
        
    }
    public void Timer()
    {
        
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _timeBar.fillAmount = (float)GetComponent<Orders.OrderScript>().Time / GetComponent<Orders.OrderScript>().Time; 
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
