using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Keluar game");
    }

    void Update()
    {
        // HOME
        if (SceneManager.GetActiveScene().name == "Home")
        {
            if (Input.GetKeyDown(KeyCode.Return))
                LoadScene(1);

            if (Input.GetKeyDown(KeyCode.Escape))
                LoadScene(2);
        }

        // PLAY
        if (SceneManager.GetActiveScene().name == "Play")
        {
            if (Input.GetKeyDown(KeyCode.Return))
                LoadScene(3);

            if (Input.GetKeyDown(KeyCode.Escape))
                LoadScene(0);
        }

        // EXIT
        if (SceneManager.GetActiveScene().name == "Exit")
        {
            if (Input.GetKeyDown(KeyCode.Return))
                ExitGame();

            if (Input.GetKeyDown(KeyCode.Escape))
                LoadScene(0);
        }

        // GAME
        if (SceneManager.GetActiveScene().name == "Game")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                LoadScene(1);
        }
    }
}