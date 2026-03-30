using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(Animator))]
[DisallowMultipleComponent]
public class PlayerAnimator : MonoBehaviour
{
    private PlayerController _controller;
    private Animator _animator;

    private int _velocityXHash;
    private int _velocityZHash;
    private int _isAimingHash;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _velocityXHash = Animator.StringToHash("velocityX");
        _velocityZHash = Animator.StringToHash("velocityZ");
        _isAimingHash = Animator.StringToHash("isAiming");
    }

    private void Update()
    {
        _animator.SetFloat(_velocityXHash, _controller.Velocity.x);
        _animator.SetFloat(_velocityZHash, _controller.Velocity.z);
    }

    private void OnAim(InputValue value)
    {
        _animator.SetBool(_isAimingHash, value.isPressed);
    }
}
