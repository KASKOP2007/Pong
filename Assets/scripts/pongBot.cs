using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    //variables

    //the y speed
    public float ySpeed = 3f;
    //the y position
    public float yPosition = 0f;
    //it calls out the gameobject named ball
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        //it sets the y position to the y position to the ball
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
    }
}
