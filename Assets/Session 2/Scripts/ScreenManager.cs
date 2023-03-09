using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject PopUpUI;

    [SerializeField] private GameObject Login_Register_Page;
    [SerializeField] private GameObject Lobby_Page;
    [SerializeField] private GameObject GamePlay_Page;

    public void loginButton_Onclick()
    {
        Login_Register_Page.GetComponent<Canvas>().enabled = false;
        Lobby_Page.GetComponent<Canvas>().enabled = true;
    }

    public void PlayNowButton_OnClick()
    {
        Lobby_Page.GetComponent<Canvas>().enabled = false;
        GamePlay_Page.GetComponent<Canvas>().enabled = true;
    }

    public void DropAndJoinNewTableButton()
    {
        GamePlay_Page.GetComponent<Canvas>().enabled = false;
        Lobby_Page.GetComponent<Canvas>().enabled = true;
        PopUpUI.SetActive(false);
    }
}
