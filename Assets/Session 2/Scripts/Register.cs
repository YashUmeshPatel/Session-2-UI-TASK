using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : BaseClass
{
    public Button RegisterTextButton;

    public void RegisterTextButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.RegisterUI);
    }

    public void Start()
    {
        RegisterTextButton.onClick.AddListener(RegisterTextButton_OnClick);
    }
}



