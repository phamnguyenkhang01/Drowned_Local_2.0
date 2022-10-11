using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health {
        set{
            print("health minus:" + value);
            health = value;
            if (health <= 0)
            {
                Defeated();
            }
        }
        get{
            return health;
        }
            }

    public float health = 1; 

    public void Defeated()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Dead!");
    }
}
