using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomNavMeshAgent : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private float timer = 5;
    private float bulletTime;
    public GameObject enemyBullet;
    public Transform BulletSpawnPoint;
    public float enemySpeed;


    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;
        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, BulletSpawnPoint.transform.position, BulletSpawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject bulletObj = Instantiate(enemyBullet, BulletSpawnPoint.transform.position, BulletSpawnPoint.transform.rotation) as GameObject;
            Destroy(bulletObj);
        }
    }
}
    

