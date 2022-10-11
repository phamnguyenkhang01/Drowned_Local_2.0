using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public DetectionZone detectionZone;

    public float moveSpeed = 500f;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {        
        if (detectionZone.detectedObjs.Count > 0)
        {
            //Calculation direction to target object
            Vector2 direction = (detectionZone.detectedObjs[0].transform.position - transform.position).normalized;            
            
            // Move towards ditected object
            rb.AddForce(direction * moveSpeed * Time.deltaTime);

        }
    }
}
