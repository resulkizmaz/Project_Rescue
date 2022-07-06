using UnityEngine;
using Player;



public class Worker : MeleeEnemy
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            playerScript.damageOfEnemyType = 2.5f;
            playerScript.damagePerSecond(3);
        }
    }
}
