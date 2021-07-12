using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float startPosition;
    public float endPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= endPosition)
        {
            if (gameObject.tag == "Cactusss")
            {
                Destroy(gameObject);

            }
            else
            {
                transform.position = new Vector2(startPosition, transform.position.y);
            }
            
        }
    }
}
