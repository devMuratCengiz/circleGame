using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public GameObject effect;
    GameManager gameManager;
    ScoreController scoreController;
    public static bool itsOk;
    // Start is called before the first frame update
    void Start()
    {
        itsOk = true;
        scoreController = GameObject.Find("Score").GetComponent<ScoreController>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GreenPoint")
        {
            scoreController.UpdateScore();
            if (itsOk)
            {
                Instantiate(effect, transform.position, Quaternion.identity);
                audioSource.Play();
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "RedPoint")
        {
            itsOk = false;
            audioSource2.Play();
            Destroy(collision.gameObject);
            Invoke("GameOverWithDelay", 2f);
            

        }
    }
    void GameOverWithDelay()
    {
        gameManager.GameOver();
    }
}
