using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    private float vertical;
    private float horisontal;
    [SerializeField, Range(1f, 5f)] private float speed = 5f;
    // Start is called before the first frame update
    private void Start()
    {
    	
    }

    // Update is called once per frame
    private void Update()
    {
        vertical = Input.GetAxis("Vertical"); // vertical movement in range [-1, 1]
        horisontal = Input.GetAxis("Horizontal"); // horisontal movement in range [-1, 1]
        
        transform.Translate(new Vector3(horisontal, 0f, vertical) * Time.deltaTime * speed);
    }
}
