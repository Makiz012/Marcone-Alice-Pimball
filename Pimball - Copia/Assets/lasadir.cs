using UnityEngine;

public class lansadir : MonoBehaviour
{
    public Transform ballStartPosition; // Posi��o inicial da bola
    public float launchForce = 800f;    // For�a do lan�amento
    public KeyCode launchKey = KeyCode.DownArrow; // Tecla para lan�ar
    private Rigidbody2D ballRb;
    private bool isBallReady = false;

    private void Update()
    {
        if (Input.GetKeyDown(launchKey) && isBallReady)
        {
            LaunchBall();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ballRb = collision.GetComponent<Rigidbody2D>();
            ballRb.linearVelocity = Vector2.zero;
            ballRb.transform.position = ballStartPosition.position;
            isBallReady = true;
        }
    }

    void LaunchBall()
    {
        if (ballRb != null)
        {
            ballRb.AddForce(Vector2.up * launchForce);
            isBallReady = false;
        }
    }
}