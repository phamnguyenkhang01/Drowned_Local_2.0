using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(speed * -1, rigid.velocity.y);
        if (rigid.velocity.x<0.8 )
        {
            rigid.velocity = new Vector2(rigid.velocity.x, speed * -1);
        }
        else if (rigid.velocity.y>1.0)
        {
            rigid.velocity = new Vector2(speed * 1, rigid.velocity.y);
        }
        else if (rigid.velocity.x < 1.6)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, speed * 1);
        }     
        

        /*
        while (rigid.velocity.x <0.8)
        {
            rigid.velocity = new Vector2(speed * -1, rigid.velocity.y);
        }
        while (rigid.velocity.y > 1.0)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, speed * -1);
        }
        while (rigid.velocity.x < 1.6)
        {
            rigid.velocity = new Vector2(speed * 1, rigid.velocity.y);
        }
        while (rigid.velocity.y< 0.905)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, speed * 1);
        }*/
    }
}
