using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game");
    }
}
