using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpUI : BaseClass
{
    public Button ExitButton;

    public void ExitButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.PopUpUI);
    }

    public void Start()
    {
        ExitButton.onClick.AddListener(ExitButton_OnClick);
    }
}
