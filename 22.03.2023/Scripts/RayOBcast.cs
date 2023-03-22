using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayOBcast : MonoBehaviour
{
    private Vector3 mousePosition, offset, defaultPosition;
    private bool check;
    private Collider2D collisionn;
    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
        collisionn = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            transform.position = Vector3.MoveTowards(transform.position, defaultPosition, 10 * Time.deltaTime);
            if (transform.position == defaultPosition)
            {
                collisionn.enabled = true;
            }
        }
    }
    private void OnMouseDown()
    {
        collisionn.enabled = false;

    }
    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }
    private void OnMouseUp()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector3.zero);

        if (ray && ray.transform.GetComponent<SpriteRenderer>().sprite.name == GetComponent<SpriteRenderer>().sprite.name)
        {
            transform.position = ray.transform.position;

        }
        else
        {
            check = true;
        }

    }
   
}
