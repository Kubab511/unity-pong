using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerGamemode : MonoBehaviour {
    public void SinglePlayer() {
        SceneManager.LoadScene("Single Player");
    }
    public void MultiPlayer() {
        SceneManager.LoadScene("Multi Player");
    }

    private void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }
}
