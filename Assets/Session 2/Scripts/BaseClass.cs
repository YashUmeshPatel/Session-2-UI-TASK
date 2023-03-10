using UnityEngine;

public class BaseClass : MonoBehaviour
{
    [HideInInspector] public Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void showScreen()
    {
        canvas.enabled = true;
    }

    public void hideScreen()
    {
        canvas.enabled = false;
    }

    public enum Screen
    {
        LoginUI,
        RegisterUI,
        LobbyPage,
        MenuCanvas,
        GamePlayPage,
        PopUpUI,
    }
}