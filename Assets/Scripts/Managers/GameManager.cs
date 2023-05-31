using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject finishPanel;
    public GameObject restartPanel;
    public string playerTag = "Player";
    public string finishTag = "Finish";

    private bool gameIsFinished = false;
    private bool isPlayerDead = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && !gameIsFinished)
        {
            gameIsFinished = true;
            StopGame();
        }
    }

    public void PlayerDied()
    {
        if (!gameIsFinished && !isPlayerDead)
        {
            isPlayerDead = true;
            OpenRestartPanel();
        }
    }

    private void StopGame()
    {
        // Disable player movement and control
        player.GetComponent<PlayerController>().enabled = false;

        // Open the finish panel
        finishPanel.SetActive(true);
    }

    private void OpenRestartPanel()
    {
        // Open the restart panel
        restartPanel.SetActive(true);
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
