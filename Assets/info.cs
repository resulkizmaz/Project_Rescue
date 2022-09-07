using UnityEngine;

public class info : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Destroy(gameObject);
    }
}
