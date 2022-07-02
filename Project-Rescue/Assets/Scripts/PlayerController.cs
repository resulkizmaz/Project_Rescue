using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] FloatingJoystick joystick;
        [SerializeField] Rigidbody rigidBody;
        [SerializeField] float speed = 0f;
        [SerializeField] GameObject infoText;



        void FixedUpdate()
        {
            Move();
        }
        void Move()
        {
            rigidBody.velocity = new Vector3(joystick.Horizontal * speed * Time.deltaTime,
                                            rigidBody.velocity.y, 
                                            joystick.Vertical * speed * Time.deltaTime);

            if (joystick.Horizontal != 0 || joystick.Vertical != 0) 
            {
                transform.rotation = Quaternion.LookRotation(rigidBody.velocity);
                Destroy(infoText);
                
            }
        }
    }
    public class EnemyController : MonoBehaviour
    {

    }
}

