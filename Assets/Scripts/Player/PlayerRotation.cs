using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Camera mainCamera;

    private void Start()
    {
        // Get the main camera reference
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Get the mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world coordinates
        Vector3 worldMousePosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, transform.position.z));

        // Calculate the direction from the player to the mouse position
        Vector3 direction = worldMousePosition - transform.position;

        // Calculate the angle between the player's forward direction and the mouse direction
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the player to face the mouse position
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}

