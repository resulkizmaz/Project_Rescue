using UnityEngine;

namespace Player
{
    public class PlayerController : MyCharacterController // status ve health scripti
    {
        public FloatingJoystick joystick;

        public int health;
        public int maxHealth;
        
        private float timePassed;

        private void Start()
        {
            health = maxHealth;
        }
        void FixedUpdate()
        {
            var moveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
            playerMove(moveDirection);
        }

        private void OnCollisionStay(Collision collision)
        {
            timePassed += Time.deltaTime;

            if (collision.gameObject.CompareTag("worker"))
            {
                
            }

            if (collision.gameObject.CompareTag("tank"))
            {

            }
        }

        public void damagePerSecond()
        {
            
        }





    }
}
