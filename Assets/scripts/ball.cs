using System;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /// <summary>
    ///settings for the ballin 
    ///-move in x and y direction
    ///-change course when it collides with a wall or paddle
    ///-scoring when ball hits left or right wall
    ///-showing score in a textfield
    ///-when ball hits a paddle it speeds it up
    /// </summary>
    
    //variables
   
   
    //horizontal and vertical position
    public float Xposition = 0f;
    public float Yposition = 0f;
    //horizontal and vertical speed
    public float Xspeed = 1f;
    public float Yspeed = 1f;
    //referance to text object (has to be linked in unity)
    public TMP_Text scoreField;
    //keeping left score and right score 
    private int leftScore = 0;
    private int rightScore = 0;
    //the score u need to win te game
    public int topScore = 5;

    //fnution to reset the ball to the start position and adds score to left or right 
    private void resetBall(string leftOrRight)
    {
        //starting position for x and y
        Xposition = 0f;
        Yposition = 0f;
        //starting speed x and y
        Xspeed = 1f;
        Yspeed = 1f;
        //displays the left and right score in the text field
        scoreField.text = leftScore + "  - " + rightScore;
        //checks arguement "leftOrRight" from the function if left or roght is typed in
        if (leftOrRight == "left")
        {
            //the ball goes right and up
            Xspeed = 5f;
            Yspeed = 5f;
        }
        else if (leftOrRight == "right")
        {
            //the ball goes left and down
            Xspeed = -5f;
            Yspeed = 5f;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Xspeed = 5f;
        Yspeed = 5f;
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