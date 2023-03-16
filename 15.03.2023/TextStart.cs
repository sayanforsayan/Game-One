using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextStart : MonoBehaviour
{
    public GameObject start;
    private void OnMouseDown()
    {
        start.SetActive(false);
    }
}
