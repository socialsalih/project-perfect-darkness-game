using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public Transform[] patrolPoints; // Array of patrol points
    public Transform player; // Reference to the player's transform
    public GameObject rifle; // Reference to the rifle GameObject
    public float chaseRange = 10f; // Range within which the enemy starts chasing the player
    public float attackRange = 5f; // Range within which the enemy starts attacking the player
    public float attackCooldown = 2f; // Cooldown between attacks
    public GameObject healthBarPrefab; // Prefab for the health bar

    private NavMeshAgent agent; // Reference to the NavMeshAgent component
    private Animator animator; // Reference to the Animator component
    private int currentPatrolIndex; // Index of the current patrol point
    private bool isChasing; // Flag indicating if the enemy is currently chasing the player
    private bool isAttacking; // Flag indicating if the enemy is currently attacking
    private bool isDead; // Flag indicating if the enemy is dead

    private Slider healthSlider; // Reference to the health bar slider
    private GameObject healthBarInstance; // Instance of the health bar

    private int maxHealth = 100; // Maximum health of the enemy
    private int currentHealth; // Current health of the enemy

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        currentHealth = maxHealth;

        // Create an instance of the health bar
        healthBarInstance = Instantiate(healthBarPrefab, transform);
        healthSlider = healthBarInstance.GetComponentInChildren<Slider>();

        // Start patrolling towards the first patrol point
        Patrol();
    }

    private void Update()
    {
        if (isDead)
            return;

        if (isChasing)
        {
            // Chase the player
            Chase();

            // Check if the player is within attack range
            if (Vector3.Distance(transform.position, player.position) <= attackRange && !isAttacking)
            {
                // Start attacking
                Attack();
            }
        }
        else
        {
            // Patrol between the points
            Patrol();
        }
    }

    private void Patrol()
    {
        if (patrolPoints.Length == 0)
            return;

        agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        animator.SetBool("IsPatrolling", true);

        // Check if the enemy reached the current patrol point
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            // Move to the next patrol point
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }
    }

    private void Chase()
    {
        agent.SetDestination(player.position);
        animator.SetBool("IsPatrolling", false);
        animator.SetBool("IsChasing", true);
    }

    private void Attack()
    {
        isAttacking = true;
        animator.SetBool("IsChasing", false);
        animator.SetBool("IsAttacking", true);

        // Perform attack logic here
        // For example, you can shoot the rifle or trigger an attack animation event

        // Reduce enemy's health based on the weapon type
        int damage = 0;

       /* if (rifle.activeSelf)
        {
            damage = 50;
        }
        else if (pistol.activeSelf)
        {
            damage = 25;
        }
        else if (knife.activeSelf)
        {
            damage = 100;
        } */

        TakeDamage(damage);

        // After attacking, start the cooldown
        Invoke("ResetAttack", attackCooldown);
    }

    private void ResetAttack()
    {
        isAttacking = false;
        animator.SetBool("IsAttacking", false);
    }

    public void TakeDamage(int damage)
    {
        if (isDead)
            return;

        currentHealth -= damage;
        healthSlider.value = (float)currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;
        animator.SetTrigger("Die");

        // Disable the rifle GameObject to make it disappear
        rifle.SetActive(false);

        // Add logic to handle enemy's death, such as adding score or triggering other events
        Destroy(gameObject, 3f); // Delayed destroy the enemy object after the death animation finishes
    }
}
