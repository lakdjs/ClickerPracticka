using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Image _timeBar;
    [SerializeField] private Button _surpriseBox;
    public int _maxTime;
    public float _timeLeft;
    public bool TimerOnOff;
    private bool _timeStoped;
    private Orders.OrderScript _orderScript;
    private BakeScript _bakeScript;
    private float x;
    private int random;

    public void Start()
    {
        random = Random.Range(0,4);
        if(random != 3)
        {
            _surpriseBox.GetComponent<Image>().enabled = false;
            _surpriseBox.enabled = false;
        }
        x = 0;
        _timeStoped = false;
        _surpriseBox.onClick.AddListener(StopingTimer);
        TimerOnOff = false;
        _bakeScript = FindFirstObjectByType<BakeScript>();
}
    void Update()
    {
        Debug.Log(x);
        if(TimerOnOff)
        {
            Timer();         
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(PlayerPrefs.GetInt("OrdersDone"));
            Debug.Log(PlayerPrefs.GetInt("Lvl"));
        }
    }
    public void Timer()
    {
        if(x>=5)
        {
            _timeStoped = false;
        }
        if (_timeLeft > 0 && _timeStoped == false)
        {
            _timeLeft -= Time.deltaTime;

            _timeBar.fillAmount = _timeLeft / _maxTime; 
        }
        else if(_timeLeft <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void StopingTimer()
    {
        PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")-1000);
        _timeStoped = true;
        InvokeRepeating("TimerSeconds",1,1);
        _surpriseBox.GetComponent<Image>().enabled = false;
        _surpriseBox.enabled = false;
    }
    private void TimerSeconds()
    {
        x += 1;
    }
}
