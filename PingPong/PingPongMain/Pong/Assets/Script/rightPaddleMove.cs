using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPaddleMove : MonoBehaviour
{
    //variables
    public float speed = 0.05f;
    public float yBorder = 4.5f;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Basic AI: Follow the ball's Y position
        if (ball != null)
        {
            if (ball.transform.position.y > transform.position.y && transform.position.y < yBorder)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed); // Move up
            }
            else if (ball.transform.position.y < transform.position.y && transform.position.y > -yBorder)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - speed); // Move down
            }
        }
    }
}
