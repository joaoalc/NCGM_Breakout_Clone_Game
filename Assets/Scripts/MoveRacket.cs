using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Horizontal";
    public GameObject spawner;
    public GameObject ball;
    public GameObject bricks;
    public GameObject spawnerbricks;

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0) * speed;
        if(Input.GetKeyDown("space"))
        {
            Instantiate(ball, spawner.transform);
            Instantiate(bricks, spawnerbricks.transform.position,spawnerbricks.transform.rotation);
        }
    }

    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        // ascii art:
        // ||  2 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -2 <- at the bottom of the racket
        return 2 * (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            // Calculate hit Factor
            float x = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity with dir * speed
            col.gameObject.GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}