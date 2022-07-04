using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] PlayerController player;
   
    private void FixedUpdate()
    {
        Debug.Log("fixed update içinde");
        if (player.joystick.Horizontal != 0 || player.joystick.Vertical != 0) 
        {
            Destroy(infoText);
        }
    }
}
