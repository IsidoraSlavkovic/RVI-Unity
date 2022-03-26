using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    private float vertical;
    private float horisontal;
    [SerializeField, Range(1f, 5f)] private float speed = 5f;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Camera cam;
    [SerializeField] Weapon weapon;
    // Start is called before the first frame update
    private void Start()
    {
    	
    }

    // Update is called once per frame
    private void Update()
    {
        vertical = Input.GetAxis("Vertical"); // vertical movement in range [-1, 1]
        horisontal = Input.GetAxis("Horizontal"); // horisontal movement in range [-1, 1]
        
        RaycastHit hit;
        if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

        Vector3 changeInPosition = new Vector3(horisontal, 0f, vertical);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        rigidbody.MovePosition(goToPositon);

        if (Input.GetMouseButton(0)) {
            if (weapon != null) {
                weapon.Shoot();
            }
        }
    }
}
