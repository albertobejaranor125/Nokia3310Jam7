using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainUIHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlsMenu;
    public static MainUIHandler instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        mainMenu.SetActive(true);
        controlsMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OpenControlsMenu();
        }else if (Input.GetKeyDown(KeyCode.E))
        {
            CloseControlsMenu();
        }else if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }else if (Input.GetKeyDown(KeyCode.Return))
        {
            PlayGame();
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenControlsMenu()
    {
        controlsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void CloseControlsMenu()
    {
        controlsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
