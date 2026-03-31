using UnityEngine;

[DisallowMultipleComponent]
public class CameraManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    
    private void Start()
    {
        playerMovement.enabled = false;
    }
}
