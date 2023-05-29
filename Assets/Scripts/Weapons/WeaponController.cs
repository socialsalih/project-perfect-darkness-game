using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public float fireRate = 0.5f;
    public string ammoTag = "Ammo";

    private float fireTimer = 0f;
    private int ammoCount = 0;

    private void Start()
    {
        ammoCount = GetAmmoCount();
    }

    private void Update()
    {
        fireTimer += Time.deltaTime;

        if (Input.GetButton("Fire1") && fireTimer >= fireRate && ammoCount > 0)
        {
            Fire();
            fireTimer = 0f;
            ammoCount--;
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        if (bulletRigidbody != null)
        {
            bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }

    private int GetAmmoCount()
    {
        GameObject[] ammoItems = GameObject.FindGameObjectsWithTag(ammoTag);
        return ammoItems.Length;
    }
}
