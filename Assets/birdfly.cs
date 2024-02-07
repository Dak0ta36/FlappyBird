using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdfly : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocity = 1;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 0 - λκμ 1 - οκμ 2-ρκμ
        {
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
