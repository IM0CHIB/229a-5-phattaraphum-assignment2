using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // รับ Input แป้นพิมพ์
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // สร้าง Vector3 เก็บค่าความเร็ว
        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // เคลื่อนที่ Rigidbody โดยใช้ AddForce
        rigidbody.AddForce(direction * speed * Time.deltaTime);
    }
}

