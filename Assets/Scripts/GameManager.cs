using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
