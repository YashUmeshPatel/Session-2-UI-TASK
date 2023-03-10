using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : BaseClass
{
    public Button loginTextButton;

    public void loginTextButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.LoginUI);
    }

    public void Start()
    {
        loginTextButton.onClick.AddListener(loginTextButton_OnClick);
    }
}



