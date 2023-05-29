using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // karakterin hýzý

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Vertical"); // A, D tuþlarýndan gelen girdiyi al
        float vertical = Input.GetAxisRaw("Horizontal"); // W, S tuþlarýndan gelen girdiyi al

        // karakterin pozisyonunu deðiþtir
        transform.position += new Vector3(-(horizontal), 0, vertical) * speed * Time.deltaTime;
    }
}