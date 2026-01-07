using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0f, vertical);

        inputDirection = inputDirection.normalized;

        Vector3 movement = inputDirection * moveSpeed * Time.deltaTime;

        transform.Translate(movement, Space.World);
    }
}
