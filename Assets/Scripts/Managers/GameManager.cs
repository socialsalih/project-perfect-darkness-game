using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject finishPanel;
    public string playerTag = "Player";
    public string finishTag = "Finish";

    private bool gameIsFinished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && !gameIsFinished)
        {
            gameIsFinished = true;
            StopGame();
        }
    }

    private void StopGame()
    {
        // Disable player movement and control
        player.GetComponent<PlayerController>().enabled = false;

        // Open the finish panel
        finishPanel.SetActive(true);
    }

    public void RestartLevel()
    {
        // Restart the level or perform any other action
        // you want when the player clicks the restart button

        // For example, you can reload the current scene
        // using the following line:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
