using UnityEngine;
using Player;

public class MeleeEnemy: MyCharacterController // MeleeEnemy = Projectile
{

    protected GameObject player;
    protected PlayerController playerScript;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.gameObject.GetComponent<PlayerController>();
    }

    private void FixedUpdate()
    {
        var  delta = -transform.position + player.transform.position;
        var toPlayer = delta.normalized;
        playerMove(toPlayer);
    }
}
