using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene6Script : MonoBehaviour
{
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
        _thirdButtonText.SetActive(false);
        _finalButton.SetActive(false);
        imagePartTwo.SetActive(false);
        InvokeRepeating("ChoiceActivation", 2.5f, 0);
    }
    public void ChoiceActivation()
    {
        _buttonOne.SetActive(true);
        _buttonTwo.SetActive(true);
    }
    public void Conitnue()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _finalButton.SetActive(false);
        _thirdButtonText.SetActive(false);
        imagePartTwo.SetActive(false);
        _mainDialog.text = "≈сли вы не продадите ваше заведение в течении 2-ух дней, то кто-то может пострадать. *ѕохититель повесил трубку*";
        _secondButtonText.SetActive(true);
    }
    public void Conitnue2()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _finalButton.SetActive(false);
        _secondButtonText.SetActive(false);
        imagePartTwo.SetActive(false);
        _mainDialog.text = "¬ы в шоке и не знаете, что делать. Ќо на следующий день нужно продолжать работать.";
        _thirdButtonText.SetActive(true);
    }
    public void Conitnue3()
    {
        _buttonOne.SetActive(false);
        _buttonTwo.SetActive(false);
        _secondButtonText.SetActive(false);
        _thirdButtonText.SetActive(false);
        imagePartTwo.SetActive(true);
        _mainDialog.text = "Ќовый день началс€ с плохой новости, кажетс€ вам не приехала часть ингридиентов, но ничего страшного, на складе у вас ещЄ остались запасы. ";
        _finalButton.SetActive(true);
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
