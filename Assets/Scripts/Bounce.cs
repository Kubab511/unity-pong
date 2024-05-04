using UnityEngine;

public class Bounce : MonoBehaviour {
    public float bounceStrength = 5f;

    private void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null) {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * bounceStrength);
        }
    }
}