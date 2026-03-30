using Unity.Cinemachine;
using UnityEngine;

namespace FinalScene.Scripts
{
    [RequireComponent(typeof(PlayerController))]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CinemachineBasicMultiChannelPerlin noiseCamera;
        [SerializeField, Min(0f)] private float transitionSpeed = 5f;

        [Header("Target Amplitude")] [SerializeField, Min(0f)]
        private float walkingTargetAmplitude = 0.5f;

        [SerializeField, Min(0f)] private float sprintingTargetAmplitude = 2f;

        [Header("Target Frequency")] [SerializeField, Min(0f)]
        private float walingTargetFrequency = 1f;

        [SerializeField, Min(0f)] private float sprintingTargetFrequency = 1.5f;

        private PlayerController _playerController;

        private float TargetAmplitude =>
            _playerController.IsSprinting ? sprintingTargetAmplitude : walkingTargetAmplitude;

        private float TargetFrequency =>
            _playerController.IsSprinting ? sprintingTargetFrequency : walingTargetFrequency;

        private void Awake()
        {
            _playerController = GetComponent<PlayerController>();
        }

        private void Start()
        {
            if (!noiseCamera)
                Debug.LogWarning("Missing Cinemachine Basic Multi Channel Perlin camera");
        }

        private void Update()
        {
            if (!noiseCamera) return;

            noiseCamera.AmplitudeGain = Mathf.Lerp(
                noiseCamera.AmplitudeGain,
                TargetAmplitude,
                Time.deltaTime * transitionSpeed);
            noiseCamera.FrequencyGain = Mathf.Lerp(
                noiseCamera.FrequencyGain,
                TargetFrequency,
                Time.deltaTime * transitionSpeed);
        }
    }
}
