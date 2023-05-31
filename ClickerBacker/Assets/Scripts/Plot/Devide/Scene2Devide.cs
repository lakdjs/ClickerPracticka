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
        _mainDialog.text = "� ������ ���� �������, ��� ���� ������� ������� ��������� � ������, ��� ������ ����������� �� ����� �������� ������������, ���� � �� �����.";
        _secondButtonText.SetActive(false);
        _thirdButtonText.SetActive(true);
    }
    public void MemoryiesMoment()
    {
        _mainDialog.text = "�� �����������, �� �����������, ��� ���� ������� ������� ���.";
        imagePartTwo.SetActive(true);
        _thirdButtonText.SetActive(!false);
        _finalButton.SetActive(true);
    }
    public void ChoiceOne()
    {
        PlayerPrefs.SetInt("ChoiceOne", 1); //���������� ����� ������
        _mainDialog.text = "�� ������� � �����, ��� ����� ���������, �� ������� ��� ������ � �� ������ ��� ������.";
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
