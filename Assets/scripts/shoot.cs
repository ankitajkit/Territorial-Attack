using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 HandPos = transform.position;
        direction = MousePos - HandPos;
        FaceMouse();
    }
    void FaceMouse()
    {
        transform.right = direction;
    }
}
