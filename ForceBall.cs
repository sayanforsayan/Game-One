using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForceBall : MonoBehaviour
{
    public GameObject ob;
    private Rigidbody2D rb;
    private int x, y;
    
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       x = 5;
       y = 5;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(x,y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name=="Righter")
        {
            x =-x;
            rb.velocity = new Vector2(x, y);

        }
        if (collision.gameObject.name == "Upper")
        {
            y = -y;
           rb.velocity = new Vector2(x, y);
        }
        if (collision.gameObject.name == "Lefter")
        {
            x = -x;
 
            rb.velocity = new Vector2(x,y);
        }
        if (collision.gameObject.tag == "Object")
        {
            y = -y;

            rb.velocity = new Vector2(x, y);
        }
        if (collision.gameObject.name == "Base")
        {
      
            y = -y;
        rb.velocity = new Vector2(x, y);
        }
        if (collision.gameObject.name == "Ground")
        {
           ob.SetActive(true);
           Destroy(gameObject);
            
        }
    }
   
}
