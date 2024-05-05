using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerMultiplayer : MonoBehaviour {
    public Ball ball;
    public PlayerPaddle player1Paddle;
    public Player2Paddle player2Paddle;
    public Text player1ScoreText;
    public Text player2ScoreText;
    private int player1Score;
    private int player2Score;
    public AudioSource score;

    private void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }

    public void Player1Scores() {
        score.Play();
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        ResetRound();
    }

    public void Player2Scores() {
        score.Play();
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        ResetRound();
    }

    private void ResetRound() {
        player1Paddle.ResetPosition();
        player1Paddle.ResetVelocity();
        player2Paddle.ResetPosition();
        player2Paddle.ResetVelocity();
        ball.ResetPosition();
        StartCoroutine(Sleep(3));
    }

    IEnumerator Sleep(int seconds) {
        yield return new WaitForSeconds(seconds);
        ball.AddStartingForce();
    }
}
