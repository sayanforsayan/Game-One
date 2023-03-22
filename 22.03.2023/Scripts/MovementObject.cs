using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObject : MonoBehaviour
{
    private bool check=true;
    private Vector3 mousePosition;
    private Vector3 defaultPosition;
    private Collider2D coll;
    private float speedd = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speedd,0,0);
        if (check)
        {
            transform.position = Vector3.MoveTowards(transform.position, defaultPosition, 10 * Time.deltaTime);
            if (transform.position == defaultPosition)
            {
                coll.enabled = true;
                check = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Stand")
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        check = false;
        coll.enabled = false;
    }
    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }
    private void OnMouseUp()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector3.zero);

        if (ray.transform?.gameObject.name == gameObject.name)
        {
            Debug.Log("Enter");

            transform.position = ray.transform.position;
            speedd = 0;
        }
        coll.enabled = true;

    }
}
