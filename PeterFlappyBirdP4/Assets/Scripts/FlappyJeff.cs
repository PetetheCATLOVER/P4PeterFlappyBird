using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyJeff : MonoBehaviour
{
    public float upForce = 200f;
    
    private bool isDead = false;
    private Rigidbody2D rigidbody2;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (isDead == false)
        {
           if (Input.GetMouseButtonDown(0))
            {
                Rigidbody2D.velocity = Vector2.zero;
                Rigidbody2D.AddForce (new Vector2 (0, upForce));
            }
        } 
    }
}
