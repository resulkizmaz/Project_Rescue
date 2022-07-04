using UnityEngine;

public class MeleeEnemy: MyCharacterController
{
    [SerializeField] PlayerController player;

    private void FixedUpdate()
    {
        var  delta = -transform.position + player.transform.position;
        var toPlayer = delta.normalized;
        playerMove(toPlayer);
    }
}
