using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public float detectionRange = 10f;
    public float detectionDuration = 5f;

    private bool isPlayerDetected = false;
    private float detectionTimer = 0f;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (isPlayerDetected)
        {
            detectionTimer += Time.deltaTime;
            if (detectionTimer >= detectionDuration)
            {
                PlayerFailed();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerDetected = true;
            gameManager.PlayerDied();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerDetected = false;
            detectionTimer = 0f;
        }
    }

    private void PlayerFailed()
    {
        gameManager.PlayerDied();
    }
}
