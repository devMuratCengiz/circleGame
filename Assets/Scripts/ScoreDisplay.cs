using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = "Your Score : " + ScoreController.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
