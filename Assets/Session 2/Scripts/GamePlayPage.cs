using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayPage : BaseClass
{
    public Button PlayNowButton;
    public Button DropAndMoveButton;

    public void PlayNowButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.GamePlayPage);
    }

    public void DropAndMoveButton_OnClick()
    {
        ScreenManager.instance.showNextScreen(Screen.GamePlayPage);
    }

    public void Start()
    {
        PlayNowButton.onClick.AddListener(PlayNowButton_OnClick);
        DropAndMoveButton.onClick.AddListener(PlayNowButton_OnClick);
    }
}
