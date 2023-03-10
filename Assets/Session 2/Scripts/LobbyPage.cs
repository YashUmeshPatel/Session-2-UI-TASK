using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyPage : BaseClass
{
    public Button LoginButton;
    public Button DropAndJoinButton;


    public void LoginButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.LobbyPage);
    }

    public void DropAndJoinButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.LobbyPage);
    }

    public void Start()
    {
        LoginButton.onClick.AddListener(LoginButton_OnClick);
        DropAndJoinButton.onClick.AddListener(LoginButton_OnClick);
    }
}
