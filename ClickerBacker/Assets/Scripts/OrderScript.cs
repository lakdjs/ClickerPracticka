using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Orders
{
    public partial class OrderScript : MonoBehaviour
    {
        [SerializeField] private int _time;
        [SerializeField] private int _coindsAdd;
        [SerializeField] private int _coinsSub;
        [SerializeField] private int _clicksQuantity;
        private TimerScript _timerScript;
        [SerializeField] private BakeScript _bakeScript;
        [SerializeField] private Button[] _buttons;
        public bool IsWatched = false;
        public enum OrderDone
        {
            Win,
            Lose
        }
        public enum Type
        {
            VeryEasy,
            Easy,
            Medium,
            Hard,
            Insane
        }
        public enum Glaze
        {
        Component1,
        Component2,
        Component3
        }
        public enum Cake
        {
        Component1,
        Component2,
        Component3
        }
        public enum Decoration
        {
        Component1,
        Component2,
        Component3
        }
        public int Time { get; private set; }
        public int CoinsAdd { get; private set; }
        public int CoinsSub { get; private set; }
        public int ClicksQuantity { get; private set; }
        public Type OrderType { get; private set; }
        public Glaze GlazeType { get; private set; }
        public Cake CakeType { get; private set; }
        public Decoration DecorationType { get; private set; }
        public OrderDone? OrderResult { get; set; }


        private void Start()
        {
            _timerScript = GetComponent<TimerScript>();//
            _timerScript.TimerOnOff = true;
            NewOrder();
            _timerScript._maxTime = Time;
            _timerScript._timeLeft = Time;
            _bakeScript.SetBaking = false;
            IsWatched = false;
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].interactable = true;
            }
        }
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log(_timerScript.TimerOnOff);
            }
            if(Input.GetKeyDown(KeyCode.E))
            {
               
            }
            if(Input.GetKeyDown(KeyCode.H))
            {
                Debug.Log($"ordertype-{OrderType},time-{Time},coinsadd-{CoinsAdd},coinssub-{CoinsSub},glazetype-{GlazeType},caketype-{CakeType},decorationtype-{DecorationType}");
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Debug.Log(PlayerPrefs.GetInt("Coins"));
                Debug.Log("coins");
            }
           if(_timerScript._timeLeft <= 0&&_timerScript.TimerOnOff&&IsWatched == false)
           {
                if (_bakeScript.Cake[0] is null)
                {
                    for (int i = 0; i < _bakeScript.Cake.Length; i++)
                    {
                        _bakeScript.Cake[i] = new GameObject();
                    }
                }
                if (GlazeType.ToString() == _bakeScript.Cake[0].tag.ToString()&&
                   CakeType.ToString()==_bakeScript.Cake[1].tag.ToString()&&
                   DecorationType.ToString()==_bakeScript.Cake[2].tag.ToString())
                {
                   OrderResult = (OrderDone)0;
                    PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") + CoinsAdd);
                }
                else
                {
                   OrderResult = (OrderDone)1;
                    PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - CoinsSub);
                }
                IsWatched = true;
                _timerScript.TimerOnOff = false;
                Debug.Log(OrderResult);
            }
        }
        private void NewOrder()
        {
            int random = Random.Range(0, (int)Type.Insane+1);
            OrderType = (Type)random;
            Time = OrderFields(_time, (int)OrderType);
            CoinsAdd = OrderFields(_coindsAdd, (int)OrderType);
            CoinsSub = OrderFields(_coinsSub, (int)OrderType);
            ClicksQuantity = OrderFields(_clicksQuantity, (int)OrderType);
            GlazeType = (Glaze)Random.Range(0,(int)Glaze.Component3+1);
            CakeType = (Cake)Random.Range(0,(int)Cake.Component3+1);
            DecorationType = (Decoration)Random.Range(0,(int)Decoration.Component3+1);
        }
        private int OrderFields(int smth2, int random)
        {
            int smth;
            smth = smth2 + (smth2 * random);
            return smth;
        }
    }
}

