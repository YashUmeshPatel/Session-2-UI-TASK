using System.Collections.Generic;
using UnityEngine;


class ScreenManager : BaseClass
{
    public List<BaseClass> ScreenList;

    BaseClass CurrentScreen;

    public static ScreenManager instance;

    private void Awake()
    {
        instance = this;
        CurrentScreen = ScreenList[0];
    }
    public void showNextScreen(Screen MyScreen)
    {
        CurrentScreen.hideScreen();
        ScreenList[(int)MyScreen].showScreen();
        CurrentScreen = ScreenList[(int)MyScreen];
    }
}


