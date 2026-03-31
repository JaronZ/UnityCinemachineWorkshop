using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class CameraController : MonoBehaviour
{
    private PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        // Set the Noise Amplitude and Noise Frequency here
    }
}
