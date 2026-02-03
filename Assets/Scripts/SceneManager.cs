using UnityEngine;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private GameObject MainScreen;
    [SerializeField] private GameObject RaceCreatorScreen;
    
    public void ShowHideMainScreen()
    {
        MainScreen.SetActive(!MainScreen.activeSelf);
    }
    public void ShowHideRaceCreatorScreen()
    {
        RaceCreatorScreen.SetActive(!RaceCreatorScreen.activeSelf);
    }
}
