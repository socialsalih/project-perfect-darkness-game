using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // karakterin h�z�

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Vertical"); // yatay (sa�/sol) hareketi al
        float moveVertical = Input.GetAxis("Horizontal"); // dikey (yukar�/a�a��) hareketi al

        // W, A, S, D tu�lar�na kar��l�k gelen girdileri al
        float moveW = Input.GetKey(KeyCode.W) ? 1f : 0f;
        float moveA = Input.GetKey(KeyCode.A) ? -1f : 0f;
        float moveS = Input.GetKey(KeyCode.S) ? -1f : 0f;
        float moveD = Input.GetKey(KeyCode.D) ? 1f : 0f;

        // t�m girdileri birle�tir
        float moveHorizontalTotal = moveHorizontal + moveS+ moveW;
        float moveVerticalTotal = moveVertical + moveA + moveD;

        Vector3 movement = new Vector3(moveHorizontalTotal, 0.0f, moveVerticalTotal); // hareket vekt�r� olu�tur

        transform.position += movement * speed * Time.deltaTime; // karakteri hareket ettir
    }
}