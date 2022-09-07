using UnityEngine;
using Player;



public class Tank : MeleeEnemy
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            playerScript.damageOfEnemyType = 5.5f;
            playerScript.damagePerSecond(3);
        }

    }
}
