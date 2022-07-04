using UnityEngine;

public class PlayerController : MyCharacterController
{
    public FloatingJoystick joystick;
    void FixedUpdate()
    {
        var moveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        playerMove(moveDirection);
    }
}
