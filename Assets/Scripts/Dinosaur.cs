using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump ;
    bool isjumping;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isjumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isjumping==false)
        {
            rb.velocity = new Vector2(0, jump);
            isjumping = true;
        }
    }
    private void OnCollisionEnter2D ( Collision2D collision)
    {
        isjumping = false;
        if (collision.gameObject.tag == "Cactusss")
        {
            gm.GameOver();
        }
    }

}
