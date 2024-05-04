using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerMultiplayer : MonoBehaviour {
    public Ball ball;
    public Paddle player1Paddle;
    public Paddle player2Paddle;
    public Text player1ScoreText;
    public Text player2ScoreText;
    private int player1Score;
    private int player2Score;

    private void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }

    public void Player1Scores() {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        ResetRound();
    }

    public void Player2Scores() {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        ResetRound();
    }

    private void ResetRound() {
        player1Paddle.ResetPosition();
        player2Paddle.ResetPosition();
        ball.ResetPosition();
        StartCoroutine(Sleep(3));
    }

    IEnumerator Sleep(int seconds) {
        yield return new WaitForSeconds(seconds);
        ball.AddStartingForce();
    }

}
