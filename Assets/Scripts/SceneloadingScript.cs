using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneloadingScript : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private string _firstName;
    [SerializeField] private string _secondName;
    [SerializeField] private string _thirdName;
    [SerializeField] private string _fourthName;
    [SerializeField] private string _fifthName;
    private void Update()
    {
        if(PlayerPrefs.GetInt("OrdersDone")==3&&PlayerPrefs.GetInt("Lvl")==0)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene3");
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 6 && PlayerPrefs.GetInt("Lvl") == 1)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene4");
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 9 && PlayerPrefs.GetInt("Lvl") == 2)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene4");
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 12 && PlayerPrefs.GetInt("Lvl") == 3)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene5");
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 15 && PlayerPrefs.GetInt("Lvl") == 4)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene6");
        }
        if (PlayerPrefs.GetInt("OrdersDone") == 6 && PlayerPrefs.GetInt("Lvl") == 5)
        {
            PlayerPrefs.SetInt("Lvl", PlayerPrefs.GetInt("Lvl") + 1);
            SceneLoadMethod("Scene7");
        }
    }
    public void SceneLoadMethod(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitMethod()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
