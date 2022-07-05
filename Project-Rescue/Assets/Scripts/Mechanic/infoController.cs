using UnityEngine;
using TMPro;
using Player;

public class infoController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] PlayerController player;
   
    private void FixedUpdate()
    {
        if (player.joystick.Horizontal != 0 || player.joystick.Vertical != 0) 
        {
            Destroy(infoText);
            gameObject.GetComponent<infoController>().enabled = false;
        }
    }
}
