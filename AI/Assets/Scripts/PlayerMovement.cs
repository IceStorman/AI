using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float inputX;
    private float inputZ;
    [SerializeField] private float speed = 12f;
    [SerializeField] private float rotationSpeed = 30f;

    [SerializeField] private Rigidbody rig;

    private void FixedUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        ///rig.velocity = new Vector3(rig.velocity.x, rig.velocity.y, inputZ * speed);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}