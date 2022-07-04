using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField][Range(200, 700)] float speed;

    protected void playerMove(Vector3 direction)
    {
        rigidBody.velocity = direction * speed * Time.deltaTime;
    }
}

