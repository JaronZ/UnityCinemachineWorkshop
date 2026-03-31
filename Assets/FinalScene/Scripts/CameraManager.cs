using Unity.Cinemachine;
using UnityEngine;

namespace FinalScene.Scripts
{
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private CinemachineSequencerCamera cutsceneCamera;
        [SerializeField] private CinemachineVirtualCameraBase playerCamera;

        private int CutsceneInstructionCount => cutsceneCamera.Instructions.Count;
        private int _cutsceneCutAndBlendsAmount;

        private void Start()
        {
            playerMovement.enabled = false;
        }

        public void OnCutOrBlendFinished()
        {
            _cutsceneCutAndBlendsAmount++;
            if (_cutsceneCutAndBlendsAmount >= CutsceneInstructionCount)
            {
                cutsceneCamera.enabled = false;
                playerCamera.enabled = true;
                playerMovement.enabled = true;
            }
        }
    }
}
