using UnityEngine;

public class Paddle : MonoBehaviour {
    public SpriteRenderer spriteRenderer;
    public float speed = 10f;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ResetPosition() {
        transform.position = new Vector2(transform.position.x, 0f);
    }
}
