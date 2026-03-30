using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
[DisallowMultipleComponent]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Min(0f)] private float speed = 5f;
    [SerializeField, Min(0f)] private float runningSpeed = 8f;
    [SerializeField, Min(0f)] private float lookSpeed = 5f;

    private PlayerController _controller;
    private Vector2 _movement;
    private Vector2 _look;
    private float _currentSpeed;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnMove(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }

    private void OnLook(InputValue value)
    {
        _look = value.Get<Vector2>();
    }

    private void Update()
    {
        _currentSpeed = _controller.IsSprinting ? runningSpeed : speed;
        _controller.Move(_currentSpeed * Time.deltaTime * _movement);
        _controller.Rotate(lookSpeed * Time.deltaTime * _look.x);
    }
}
