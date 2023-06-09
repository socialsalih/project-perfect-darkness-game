using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(20);
        }
    }

}
