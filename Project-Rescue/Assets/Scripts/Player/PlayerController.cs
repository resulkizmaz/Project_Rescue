using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class PlayerController : MyCharacterController // status ve health scripti
    {
        public FloatingJoystick joystick;

        [SerializeField] GameObject deathPannel;

        [HideInInspector] public int damageOfEnemyType = 5;

        public int health;
        public int maxHealth;

        List<int> DPSTickTimers = new List<int>();


        public bool nextLevel;

        private void Start()
        {
            health = maxHealth;

            Time.timeScale = 1f; // Zamanýn hýzýyla oynarken garantiye almak adýna illaki 1 kere kullanýrým.
            nextLevel = false;
            deathPannel.SetActive(false);
        }
        void FixedUpdate()
        {
            var moveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
            playerMove(moveDirection);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("outdoor"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                nextLevel = true;
            }
        }

        public void damagePerSecond(int ticks)
        {
            if (DPSTickTimers.Count <= 0)
            {
                DPSTickTimers.Add(ticks);
                StartCoroutine(DPS());
            }
            else
            {
                DPSTickTimers.Add(ticks);
            }
            if (health <= 0)
            {
                deathPannel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        IEnumerator DPS() // Her saniyede 1 sefer istenilen hasarý vermesi için kullandým
        {
            while (DPSTickTimers.Count > 0)
            {
                for (int i = 0; i < DPSTickTimers.Count; i++)
                {
                    DPSTickTimers[i]--;
                }
                health -= damageOfEnemyType;
                DPSTickTimers.RemoveAll(i => i == 0);
                yield return new WaitForSeconds(1.01f);
            }
        }





    }
}
