using UnityEngine;

public class ConveyorController : MonoBehaviour
{
    public float Speed = 2.0f;

    void FixedUpdate()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.position -= transform.forward * Speed * Time.deltaTime;
        rigidbody.MovePosition(rigidbody.position + transform.forward * Speed * Time.deltaTime);
    }
}
