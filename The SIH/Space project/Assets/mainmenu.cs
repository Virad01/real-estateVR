using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }

    public void Quitegame()
    {
        Application.Quit();
    }
}
