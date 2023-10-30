using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void playerVsAi()
    {
        SceneManager.LoadScene(2);
    }
    public void playerVsPlayer()
    {
        SceneManager.LoadScene(3);
    }
    public void impossibleAi()
    {
        SceneManager.LoadScene(4);
    }
    public void breakOut()
    {
        SceneManager.LoadScene(5);
    }
    public void Quit()
    { 
        Application.Quit();
        Debug.Log("Player has quit the game");
    }
}
