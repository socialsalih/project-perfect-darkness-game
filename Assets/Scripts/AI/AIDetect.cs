using UnityEngine;

public class AIDetect : MonoBehaviour
{
    public string name;
    public float attackDelay = 2f;
    public string playerTag = "Player";
    private bool canAttack = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && canAttack)
        {
            Debug.Log(name + " detected the player!");
            canAttack = false;
            Invoke("AttackPlayer", attackDelay);
        }
    }

    private void AttackPlayer()
    {
        Debug.Log(name + " is attacking the player!");
        // Insert attack logic here

        // Reset canAttack after the attack is complete
        canAttack = true;
    }
}
