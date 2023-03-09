using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject LoginUI;
    [SerializeField] private GameObject PopUpUI;
    [SerializeField] private GameObject RegisterUI;

    [SerializeField] private GameObject MenuSection;

    [SerializeField] private GameObject Login_Register_Page;
    [SerializeField] private GameObject Lobby_Page;
    [SerializeField] private GameObject GamePlay_Page;
    
    
    public void register_OnClick()
    {
        LoginUI.SetActive(false);
        RegisterUI.SetActive(true);
    }

    public void login_Onclick()
    {
        LoginUI.SetActive(true);
        RegisterUI.SetActive(false);
    }

    public void loginButton_Onclick()
    {
        Login_Register_Page.GetComponent<Canvas>().enabled = false;
        Lobby_Page.GetComponent<Canvas>().enabled = true;
    }

    public void mainMenuButton_Onclick()
    {
        MenuSection.SetActive(true);
    }

    public void mainMenu_Exit()
    {
        MenuSection.SetActive(false);
    }

    public void PlayNowButton_OnClick()
    {
        Lobby_Page.GetComponent<Canvas>().enabled = false;
        GamePlay_Page.GetComponent<Canvas>().enabled = true;
    }

    public void ExitButton_OnClick()
    {
        PopUpUI.SetActive(true);
    }

    public void DropAndJoinNewTableButton()
    {
        GamePlay_Page.GetComponent<Canvas>().enabled = false;
        Lobby_Page.GetComponent<Canvas>().enabled = true;
        PopUpUI.SetActive(false);
    }

    public void DropAndMoveButton()
    {
        PopUpUI.SetActive(false);
    }
}
