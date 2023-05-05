using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // karakterin hýzý

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Vertical"); // yatay (sað/sol) hareketi al
        float moveVertical = Input.GetAxis("Horizontal"); // dikey (yukarý/aþaðý) hareketi al

        // W, A, S, D tuþlarýna karþýlýk gelen girdileri al
        float moveW = Input.GetKey(KeyCode.W) ? 1f : 0f;
        float moveA = Input.GetKey(KeyCode.A) ? -1f : 0f;
        float moveS = Input.GetKey(KeyCode.S) ? -1f : 0f;
        float moveD = Input.GetKey(KeyCode.D) ? 1f : 0f;

        // tüm girdileri birleþtir
        float moveHorizontalTotal = moveHorizontal + moveS+ moveW;
        float moveVerticalTotal = moveVertical + moveA + moveD;

        Vector3 movement = new Vector3(moveHorizontalTotal, 0.0f, moveVerticalTotal); // hareket vektörü oluþtur

        transform.position += movement * speed * Time.deltaTime; // karakteri hareket ettir
    }
}
