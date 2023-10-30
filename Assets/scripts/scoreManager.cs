using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;

    private int player1Score = 0;
    private int player2Score = 0;

    public void UpdateScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = "Player 1 Score: " + player1Score;
        }
        else if (playerNumber == 2)
        {
            player2Score++;
            player2ScoreText.text = "Player 2 Score: " + player2Score;
        }
    }
    public void ResetScore()
    {
        player1Score = 0;
        player2Score = 0;
        player1ScoreText.text = "Player 1 Score: 0";
        player2ScoreText.text = "Player 2 Score: 0";
    }
}