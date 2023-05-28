using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orders
{
    public partial class OrderScript : MonoBehaviour
    {
        [SerializeField] private int _time;
        [SerializeField] private int _coindsAdd;
        [SerializeField] private int _coinsSub;
        [SerializeField] private int _clicksQuantity;
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


        private void Start()
        {
        }
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                NewOrder();
            }
            if(Input.GetKeyDown(KeyCode.H))
            {
                Debug.Log($"ordertype-{OrderType},time-{Time},coinsadd-{CoinsAdd},coinssub-{CoinsSub},glazetype-{GlazeType},caketype-{CakeType},decorationtype-{DecorationType}");
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                GetComponent<TimerScript>().Start();
                GetComponent<TimerScript>().Timer();
                Debug.Log("est");
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
            GlazeType = (Glaze)Random.Range(0,(int)Glaze.Component3);
            CakeType = (Cake)Random.Range(0,(int)Cake.Component3);
            DecorationType = (Decoration)Random.Range(0,(int)Decoration.Component3);
        }
        private int OrderFields(int smth2, int random)
        {
            int smth;
            smth = smth2 + (smth2 * random);
            return smth;
        }
    }
}

