using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMenu : MonoBehaviour {
    public void Quit() {
        Application.Quit();
    }

    public void Play() {
        SceneManager.LoadScene("Gamemode");
    }
}