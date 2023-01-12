using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject StagePane;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void StartGame()
    {
        StagePane.SetActive(true);
    }
    public void StageExit()
    {
        StagePane.SetActive(false);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}
