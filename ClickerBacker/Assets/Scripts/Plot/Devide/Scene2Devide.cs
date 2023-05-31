using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2Devide : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _buttonOne;
    [SerializeField] private GameObject _buttonTwo;
    [SerializeField] private Text _mainDialog;

    [SerializeField] private GameObject _secondButtonText;
    [SerializeField] private GameObject _thirdButtonText;
    [SerializeField] private GameObject _finalButton;
    [SerializeField] private GameObject imagePartTwo;
    void Start()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _secondButtonText.SetActive(false);
        imagePartTwo.SetActive(false);
        _thirdButtonText.SetActive(false);
        _finalButton.SetActive(false);
        InvokeRepeating("ChoiceActivation", 2.5f, 0);
    }
    public void ChoiceActivation()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(true);
    }
   public void Letter()
    {
        _mainDialog.text = "¬ письме было сказано, что ваша матушка уезжает ненадолго в отпуск, она просит присмотреть за вашим семейной кондитерской, пока еЄ не будет.";
        _secondButtonText.SetActive(false);
        _thirdButtonText.SetActive(true);
    }
    public void MemoryiesMoment()
    {
        _mainDialog.text = "¬ы взволнованы, но вспоминаете, как ваша матушка обучала вас.";
        imagePartTwo.SetActive(true);
        _thirdButtonText.SetActive(!false);
        _finalButton.SetActive(true);
    }
    public void ChoiceOne()
    {
        PlayerPrefs.SetInt("ChoiceOne", 1); //«апоминаем выбор игрока
        _mainDialog.text = "¬ы подошли к двери, там сто€л почтальон, он передал вам письмо и вы начали его читать.";
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _secondButtonText.SetActive(true);
    }
    public void GoToLevelOne()
    {
        Debug.Log("GoToLevel 1");
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
