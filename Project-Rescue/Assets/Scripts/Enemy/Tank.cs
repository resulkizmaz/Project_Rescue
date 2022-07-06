using UnityEngine;
using Player;



public class Tank : MeleeEnemy
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            playerScript.damagePerSecond(2);
        }

    }
}
