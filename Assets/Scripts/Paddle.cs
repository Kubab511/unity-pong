using UnityEngine;

public class Paddle : MonoBehaviour {
    public SpriteRenderer spriteRenderer;
    public float speed = 10f;
    public AudioSource bounce;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ResetPosition() {
        transform.position = new Vector2(transform.position.x, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null) {
            bounce.Play();
        }
    }
}
