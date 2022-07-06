using UnityEngine;
using Player;



public class Worker : MeleeEnemy
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            playerScript.damagePerSecond(1);
        }
    }
}
