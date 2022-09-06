using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField][Range(100, 500)] float speed;

    protected void Moving(Vector3 direction)
    {
        rigidBody.velocity = direction * speed * Time.deltaTime;
    }
}

