using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGreen;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = randomDirection * moveSpeed;
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
