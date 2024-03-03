using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ความเร็วในการเคลื่อนที่
    public float moveSpeed = 5.0f;

    // Rigidbody ของ Object
    private Rigidbody rb;

    void Start()
    {
        // เก็บ Rigidbody ของ Object ไว้
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // รับค่า Input จากคีย์บอร์ด
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // คำนวณทิศทางการเคลื่อนที่
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

        // เคลื่อนที่ Object โดยใช้ Rigidbody
        rb.AddForce(moveDirection * moveSpeed);
    }
}


