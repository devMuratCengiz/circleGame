using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        if (Circle.itsOk)
        {
            score++;
            scoreText.text = score.ToString();
            if (score==10)
            {
                PointSpawner.spawnRate -= .5f;
            }
            if (score == 20)
            {
                PointSpawner.spawnRate -= .5f;
            }
        }
    }
}
