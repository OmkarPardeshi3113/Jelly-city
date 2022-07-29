using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit(0);
    }
}
