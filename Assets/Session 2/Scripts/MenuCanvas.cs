using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCanvas : BaseClass
{
    public Button MenuButton;

    public void MenuButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.MenuCanvas);
    }

    public void Start()
    {
        MenuButton.onClick.AddListener(MenuButton_OnClick);
    }
}
