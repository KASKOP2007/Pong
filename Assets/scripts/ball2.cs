using System;
using TMPro;
using UnityEngine;

public class NewBehaviour : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float Xspeed = 25f;
    public float Yspeed = 25f;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 5;

    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        Xspeed = 25f;
        Yspeed = 25f;
        scoreField.text = leftScore + "  - " + rightScore;
        if (leftOrRight == "left")
        {
            Xspeed = 25f;
            Yspeed = 25;
        }
        else if (leftOrRight == "right")
        {
            Xspeed = -25;
            Yspeed = -25;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Xspeed = 25;
        Yspeed = 25;
        scoreField.text = "0 - 0";
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if (leftScore >= topScore)
        {
            scoreField.text = "Left Player has won!";
            Xspeed = 0;
            Yspeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }
        else if (rightScore >= topScore)
        {
            scoreField.text = "Right Player has won!";
            Xspeed = 0;
            Yspeed = 0;
            Xposition = 0f;
            Yposition = 0f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            Yspeed = Yspeed * -1f;
        }

        else if (collision.gameObject.CompareTag("player1"))
        {
            Xspeed = Xspeed * -1.1f;
        }
        else if (collision.gameObject.CompareTag("player2"))
        {
            Xspeed = Xspeed * -1.1f;
        }
        if (collision.gameObject.CompareTag("scoreWallPlayer1"))
        {
            leftScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("scoreWallPlayer2"))
        {
            rightScore++;
            resetBall("right");
        }

    }
}