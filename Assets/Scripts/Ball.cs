using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    public float initialMaxAngle = Mathf.PI / 2;

    void Start()
    {
        // Initial Velocity
        float initialAngle = Random.Range(-initialMaxAngle, initialMaxAngle);

        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(initialAngle), Mathf.Sin(initialAngle)) * -speed;
    }
}