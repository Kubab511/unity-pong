using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed = 200f;
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start() {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition() {
        rb.velocity = Vector3.zero;
        rb.position = Vector3.zero;
    }

    public void AddStartingForce() {
        //left or right
        float x = Random.value < 0.5f ? -1f : 1f;
        //angle going up or down
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force) {
        rb.AddForce(force);
    }
}