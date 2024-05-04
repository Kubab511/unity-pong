using UnityEngine;

public class Player2Paddle : Paddle {
    private Vector3 direction;

    private void Update() {
        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4.235) {
            direction = Vector3.up * speed;
        } else if(Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.235) {
            direction = Vector3.down * speed;
        } else {
            direction = Vector3.zero;
        }

        transform.position += direction * Time.deltaTime;
    }
}
