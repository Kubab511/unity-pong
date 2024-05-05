using UnityEngine;

public class ComputerPaddle : Paddle {
    public Rigidbody2D ball;
    private Vector3 direction;

    private void Update() {
        //ball going towards paddle (to the right)
        if(ball.velocity.x > 0f) {
            //if ball is above paddle
            if(ball.position.y > transform.position.y && transform.position.y < 4.235) {
                direction = Vector3.up * speed;
            } else if(ball.position.y < transform.position.y && transform.position.y > -4.235){
                direction = Vector3.down * speed;
            } else {
                direction = Vector3.zero;
            }
        } else {
            direction = Vector3.zero;
        }

        transform.position += direction * Time.deltaTime;
    }

    public void ResetVelocity() {
        direction = Vector3.zero;
    }
}