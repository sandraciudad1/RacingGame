using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{ 
    public float turnSpeed = 50f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        cameraSwitcher camSwitcher = GameObject.Find("MainCamera").GetComponent<cameraSwitcher>();
        if (camSwitcher!=null && camSwitcher.canStart)
        {
            movement(15f);
        }

        camSwitchBtns camSwitchBtns = GameObject.Find("MainCamera").GetComponent<camSwitchBtns>();
        if (camSwitchBtns != null)
        {
            movement(1.2f);
        }
    }

    void movement(float speed)
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * moveInput * speed;
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);

        float turnInput = Input.GetAxis("Horizontal");
        Quaternion turn = Quaternion.Euler(0f, turnInput * turnSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }
}
