using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerSingleplayer : MonoBehaviour {
    public Ball ball;
    public PlayerPaddle playerPaddle;
    public ComputerPaddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int playerScore;
    private int computerScore;
    public AudioSource score;

    private void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }

    public void PlayerScores() {
        score.Play();
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores() {
        score.Play();
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetRound();
    }

    private void ResetRound() {
        playerPaddle.ResetPosition();
        playerPaddle.ResetVelocity();
        computerPaddle.ResetPosition();
        computerPaddle.ResetVelocity();
        ball.ResetPosition();
        StartCoroutine(Sleep(2));
    }

    IEnumerator Sleep(int seconds) {
        yield return new WaitForSeconds(seconds);
        ball.AddStartingForce();
    }
}
