using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // karakterin h�z�

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Vertical"); // A, D tu�lar�ndan gelen girdiyi al
        float vertical = Input.GetAxisRaw("Horizontal"); // W, S tu�lar�ndan gelen girdiyi al

        // karakterin pozisyonunu de�i�tir
        transform.position += new Vector3(-(horizontal), 0, vertical) * speed * Time.deltaTime;
    }
}