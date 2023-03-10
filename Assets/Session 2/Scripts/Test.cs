using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Test : MonoBehaviour
{
    public List<ScreenView> screenList;
    public Canvas currentScreenCanvas;
    public static Test instance;


    public void Awake()
    {
        instance = this;
    }
    

    public void ShowScreen(Screen screen)
    {
        if (currentScreenCanvas != null)
        {
            currentScreenCanvas.enabled = false;

        }
        currentScreenCanvas = screenList.Find(x => x.screenEnum == screen).screenCanvas;
        currentScreenCanvas.enabled = true;

    }

    public enum Screen
    {
        MainMenuUI,
        MainGamePlayUI,
        GameOverUI,
        LevelSelectionUI,

    }

    [System.Serializable]
    public class ScreenView
    {
        public Screen screenEnum;
        public Canvas screenCanvas;
    }

}
