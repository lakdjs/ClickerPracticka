using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timeBar;
    public int _maxTime;
    public float _timeLeft;
    public bool TimerOnOff;
    private Orders.OrderScript _orderScript;
    private BakeScript _bakeScript;

    public void Start()
    {
        TimerOnOff = false;
        _bakeScript = FindFirstObjectByType<BakeScript>();
}
    void Update()
    { 
        if(TimerOnOff)
        {
            Timer();         
        }
        //if(Input.GetKeyDown(KeyCode.L))
        //{
        //   Debug.Log( _bakeScript.Cake[0]);
        //   Debug.Log( _bakeScript.Cake[1]);
        //   Debug.Log( _bakeScript.Cake[2]);
        //}
    }
    public void Timer()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;

            _timeBar.fillAmount = _timeLeft / _maxTime; 
        }
    }
}
