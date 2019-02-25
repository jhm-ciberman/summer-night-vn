using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject credits;

    public GameObject mainMenu;

    public GameObject options;

    public GameObject startGame;

    public SceneLoader sceneLoader;

    private GameObject currentVisibleScreen;

    private void Awake()
    {
        Show(mainMenu);
    }


    private void Show(GameObject go)
    {
        if (currentVisibleScreen)
        {
            currentVisibleScreen.SetActive(false);
        }
        currentVisibleScreen = go;
        go.SetActive(true);
    }

    public void GoToCredits()
    {
        Show(credits);
    }

    public void GoToMainMenu()
    {
        Show(mainMenu);
    }

    public void GoToOptions()
    {
        Show(options);
    }

    public void GoToStartGame()
    {
        Show(startGame);
        sceneLoader.LoadScene("Main");
    }
}