using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[DisallowMultipleComponent]
public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;
    public Vector3 Velocity => _controller.velocity;
    
    public bool IsSprinting { get; private set; }

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Move(Vector2 movement)
    {
        Vector3 move = transform.right * movement.x + transform.forward * movement.y;
        _controller.Move(move);
    }

    public void Rotate(float rotation)
    {
        Vector3 rotate = transform.up * rotation;
        transform.Rotate(rotate);
    }

    private void OnSprint(InputValue value)
    {
        IsSprinting = value.isPressed;
    }
}
