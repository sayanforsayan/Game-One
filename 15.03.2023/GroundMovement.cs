using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.02f,0,0);
            //
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.02f, 0, 0);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-1.8f,1.87f),Mathf.Clamp(transform.position.y,-4.88f,-4.88f));
    }
}
