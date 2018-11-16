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
}