using UnityEngine;
using Player;

public class MeleeEnemy: MyCharacterController // MeleeEnemy = Projectile
{

    GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        var  delta = -transform.position + player.transform.position;
        var toPlayer = delta.normalized;
        playerMove(toPlayer);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            //collision.gameObject.GetComponent<PlayerController>().damagePerSecond();
        }
        
    }
}
