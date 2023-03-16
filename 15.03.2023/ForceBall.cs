using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForceBall : MonoBehaviour
{
    public LevelScripts levelObject;
    public GameObject ob;
    public GameObject win;
    private Rigidbody2D rb;
    private int x, y;
    private int count;
    private Vector3 resetPosition;
    
    void Start()
    {
       resetPosition = transform.position;
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

        }else if (collision.gameObject.name == "Upper")
        {
            y = -y;
           rb.velocity = new Vector2(x, y);
        }else if (collision.gameObject.name == "Lefter")
        {
            x = -x;
 
            rb.velocity = new Vector2(x,y);
        }else if (collision.gameObject.tag == "Object")
        {
            y = -y;
           rb.velocity = new Vector2(x, y);
        }else if (collision.gameObject.name == "Base")
        {
            y = -y;
            rb.velocity = new Vector2(x, y);
        }
        else if(collision.gameObject.tag=="Enemy")
        {
            count = count + 1;
        
            if (count==9)
              {
               win.SetActive(true);
               transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                count = 0;

              }
            else if(count==10)
            {
                win.SetActive(true);
                transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                count = 0;
            }
            else if (count==12)
            {
                win.SetActive(true);
                transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                count = 0;
            }
            else if (count==16)
            {
                win.SetActive(true);
                transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                count = 0;
            }
            else if (count==17)
            {
                win.SetActive(true);
                transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                count = 0;
            }
        }

        if (collision.gameObject.name == "Ground")
        {
           ob.SetActive(true);
           Destroy(gameObject);
        }

    }
 public void nextLevel()
    {
       
        transform.position = resetPosition;
        levelObject.Next_Level_Load();
    }   
   
}
