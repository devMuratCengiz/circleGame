using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class CirclesController : MonoBehaviour
{
    
    
    public float rotateSpeed = 100f;
    private float x;
    
    // Start is called before the first frame update
    void Start()
    {
        
       
        x = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Circle.itsOk)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward * x, rotateSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                x *= -1;
            }
           
        }     
    }
   
}
