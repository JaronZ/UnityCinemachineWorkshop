# 📷 Cinemachine Workshop

> [!IMPORTANT]
> Make sure to install Unity 6000.3.6f1 if you haven't done so already

## Chapter 1 - Setup

### Step 1 - Opening the Project

1. Clone this repository and add it as project to Unity.
2. Open the project using Unity 6000.3.6f1.

### Step 2 - Adding a Cinemachine Brain

1. In the project menu, go to `Assets/Scenes` and open `WorkshopScene`.

<div>
  <img width="374" height="320" alt="image" src="https://github.com/user-attachments/assets/c69bbf59-7129-48ac-a9a4-de804b3e96c0" />
</div>

2. In the hierarchy menu, click on the `Main Camera` game object.

<div>
  <img width="363" height="177" alt="image" src="https://github.com/user-attachments/assets/bffd1fe7-c752-4c31-b683-a697f3cde963" />
</div>

3. In the inspector menu, click on `Add Component`.

<div>
  <img width="452" height="550" alt="image" src="https://github.com/user-attachments/assets/6947c5ab-a80d-47a5-b791-41899c1d507b" />
</div>

4. Search for `Cinemachine Brain` and add it to the `Main Camera`.

<div>
  <img width="452" height="266" alt="image" src="https://github.com/user-attachments/assets/e2c19d69-46da-4a92-a4e7-d6658f4b2164" />
</div>

## Chapter 2 - Cutscene

### Step 1 - Empty Sequencer Camera

1. Right-click in the hierarchy menu and click on `Cinemachine > Sequencer Camera`.

<div>
  <img width="364" height="159" alt="image" src="https://github.com/user-attachments/assets/05f23147-2e6e-47e9-bf31-2cc0c126548a" />
</div>

2. Rename the created `Sequencer Camera` to `Cutscene Camera`.

<div>
  <img width="364" height="159" alt="image" src="https://github.com/user-attachments/assets/e96d7070-1aa9-458a-bb8f-49bcda169197" />
</div>

3. In the inspector menu, look for  `Instructions` in the `Cinemachine Sequencer Camera` component.

<div>
  <img width="444" height="214" alt="image" src="https://github.com/user-attachments/assets/a9ee7789-a059-4c7d-a08a-130db9d2a373" />
</div>

4. Click the `➖` button in both menus until all child cameras and instructions are removed.

<div>
  <img width="444" height="169" alt="image" src="https://github.com/user-attachments/assets/a85f8a34-f262-4016-bfae-69613c6312f1" />
</div>

### Step 2 - Dolly Camera

1. In the hierarchy menu, right-click on the previously created `Cutscene Camera` game object.

<div>
  <img width="365" height="169" alt="image" src="https://github.com/user-attachments/assets/d7515acb-1938-4a75-b8d5-6d2aafddbd10" />
</div>

2. Click on `Cinemachine > Dolly Camera with Spline`.

<div>
  <img width="365" height="183" alt="image" src="https://github.com/user-attachments/assets/017e48cf-c3d6-4f0a-a905-41f0d8d365cd" />
</div>

3. Rename the created `CinemachineCamera` to `Player Cutscene Camera`.

<div>
  <img width="365" height="183" alt="image" src="https://github.com/user-attachments/assets/38c1a2ec-7e6c-46dd-ae7d-3125f9144662" />
</div>

4. From the hierarchy menu, drag the `Y Bot` game object into the `Tracking Target` within the `Cinemachine Camera` component of the `Player Cutscene Camera` game object.

<div>
  <img width="454" height="358" alt="image" src="https://github.com/user-attachments/assets/ab0a9ad7-1628-48c2-a707-710eb78a9126" />
</div>

5. Enter the values shown below into the `Cinemachine Spline Dolly` component.

<div>
  <img width="454" height="190" alt="image" src="https://github.com/user-attachments/assets/b72e8ff7-7166-47a9-b4ea-71ab29b8ed77" />
</div>

6. Enter the values shown below into the `Cinemachine Rotation Composer` component.

<div>
  <img width="454" height="224" alt="image" src="https://github.com/user-attachments/assets/62097ae0-5fdb-40b0-8192-560789d8b54e" />
</div>

### Step 3 - Dolly Spline

1. In the hierarchy menu, click on the `Dolly Spline` game object.

<div>
  <img width="363" height="224" alt="image" src="https://github.com/user-attachments/assets/7a7485d3-f1e6-40c4-a85d-f8a9845ac562" />
</div>

2. In the inspector menu, open `Spline 0` in the `Spline Container component` if it's not already open.

<div>
  <img width="450" height="290" alt="image" src="https://github.com/user-attachments/assets/c941532f-e75f-4bdb-abd5-04179e7b9451" />
</div>

3. Click on the `➕` button under `Knot [1]` to add another knot to the spline.

<div>
  <img width="450" height="242" alt="image" src="https://github.com/user-attachments/assets/7fc0824c-e265-491a-99a7-5e94d2b3de19" />
</div>

4. Enter the values shown below into the knots of `Spline 0`.

<div>
  <img width="450" height="147" alt="image" src="https://github.com/user-attachments/assets/b9ef8915-9c31-4c3c-87c1-ea4a7b3ed441" />
</div>

### Step 4 - Wall Follow Camera

1. In the hierarchy menu, right-click on the `Cutscene Camera` game object.

<div>
  <img width="364" height="175" alt="image" src="https://github.com/user-attachments/assets/8062f664-6e11-47c1-b664-846822c689c1" />
</div>

2. Click on `Cinemachine > Targeted Cameras > Follow Camera`.

<div>
  <img width="364" height="199" alt="image" src="https://github.com/user-attachments/assets/647140ee-b1bf-4ece-b11c-4a816654e8e0" />
</div>

3. Rename the created `CinemachienCamera` to `Wall Cutscene Camera`.

<div>
  <img width="364" height="199" alt="image" src="https://github.com/user-attachments/assets/6e05bdb4-01d1-4a31-9b4d-2465a7ab3cce" />
</div>

4. Drag the `Wall Cutscene Camera` game object into the `Cutscene Camera` game object.

<div>
  <img width="364" height="199" alt="image" src="https://github.com/user-attachments/assets/5bbdf7e7-4249-41b4-bac6-f8661da7b685" />
</div>

5. From the hierarchy menu, drag the `Wall` game object into the `Tracking Target` within the `Cinemachine Camera` component of the `Wall Cutscene Camera` game object.

<div>
  <img width="452" height="351" alt="image" src="https://github.com/user-attachments/assets/8d4fcd3b-3047-4fda-bd02-d9512ee2ebb5" />
</div>

6. Enter the values shown below into the `Cinemachine Follow` component.

<div>
  <img width="452" height="91" alt="image" src="https://github.com/user-attachments/assets/447898ff-e88a-4026-a2ae-539b7362f712" />
</div>

7. Enter the values shown below into the `Cinemachine Rotation Composer` component.

<div>
  <img width="452" height="217" alt="image" src="https://github.com/user-attachments/assets/be49d187-d137-4425-9199-30694e613a63" />
</div>

### Step 5 - Collecible Follow Camera

1. In the hierarchy menu, right-click on the `Cutscene Camera` game object.

<div>
  <img width="364" height="199" alt="image" src="https://github.com/user-attachments/assets/8347aba9-3644-4458-bb58-e57d14094c53" />
</div>

2. Click on `Cinemachine > Targeted Cameras > Follow Camera`.

<div>
  <img width="364" height="218" alt="image" src="https://github.com/user-attachments/assets/644d36b4-4cf8-48a3-a10b-dd4f0b09e1e9" />
</div>

3. Rename the created `CinemachienCamera` to `Collectible Cutscene Camera`.

<div>
  <img width="364" height="218" alt="image" src="https://github.com/user-attachments/assets/7d10165d-f893-4263-b1ab-969ad3c4057b" />
</div>

4. Drag the `Collectible Cutscene Camera` game object into the `Cutscene Camera` game object.

<div>
  <img width="364" height="218" alt="image" src="https://github.com/user-attachments/assets/6db791bb-7623-4bdb-a6f1-0bc8370d7a44" />
</div>

5. From the hierarchy menu, drag the `Collectible` game object into the `Tracking Target` within the `Cinemachine Camera` component of the `Collectible Cutscene Camera` game object.

<div>
  <img width="453" height="349" alt="image" src="https://github.com/user-attachments/assets/4dcccb6e-0a5c-4da6-8c63-61b0036371df" />
</div>

6. Enter the values shown below into the `Cinemachine Follow` component.

<div>
  <img width="453" height="89" alt="image" src="https://github.com/user-attachments/assets/803cf550-4659-4a79-b7c2-dac19bbdf6a1" />
</div>

7. Enter the values shown below into the `Cinemachine Rotation Composer` component.

<div>
  <img width="453" height="224" alt="image" src="https://github.com/user-attachments/assets/657590be-c6b7-4df0-b055-d7e7e9bd7e5e" />
</div>

### Step 6 - Camera Transitions

1. In the hierarchy menu, click on `Cutscene Camera`.

<div>
  <img width="365" height="214" alt="image" src="https://github.com/user-attachments/assets/086050f7-3e8d-4408-a9e6-af7c070c7bb4" />
</div>

2. In the inspector menu, add three empty instructions under `Instructions` in the `Cinemachine Sequencer Camera` component.

<div>
  <img width="452" height="547" alt="image" src="https://github.com/user-attachments/assets/febb7a69-60ea-41c5-9f6b-d675890c57c9" />
</div>

3. Enter the values shown below into `Instructions` within the `Cinemachine Sequencer Camera` component.

<div>
  <img width="452" height="258" alt="image" src="https://github.com/user-attachments/assets/024a0003-a55c-4256-980e-04a7e9a26491" />
</div>

4. Enter play mode to see the cutscene in action and exit play mode when you're done.

## Chapter 3 - Player Camera

### Step 1 - Empty State-Driven Camera

1. Right-click in the hierarchy menu and click on `Cinemachine > State-Driven Camera`.

<div>
  <img width="365" height="198" alt="image" src="https://github.com/user-attachments/assets/00da7a57-145f-4eb8-a9ee-f898b7f34fd1" />
</div>

2. Rename the created `Sequencer Camera` to `Player Camera`.

<div>
  <img width="365" height="198" alt="image" src="https://github.com/user-attachments/assets/2368fc9c-b45f-4c84-a670-d0cc46efd64d" />
</div>

3. In the inspector menu, look for  `Instructions` in the `Cinemachine State Driven Camera` component.

<div>
  <img width="451" height="563" alt="image" src="https://github.com/user-attachments/assets/975a2e5e-79bc-49c1-9145-9259624b4de9" />
</div>

4. Click the `➖` button until all child cameras are removed.

<div>
  <img width="451" height="172" alt="image" src="https://github.com/user-attachments/assets/04cb7fff-965a-405c-a323-9da2a51df193" />
</div>

### Step 2 - First-Person Camera

1. In the hierarchy menu, right-click on the `Player Camera` game object.

<div>
  <img width="363" height="196" alt="image" src="https://github.com/user-attachments/assets/6503bb5f-c120-438b-9ae3-10eed18dd72e" />
</div>

2. Click on `Cinemachine > Targeted Cameras > Follow Camera`.

<div>
  <img width="363" height="214" alt="image" src="https://github.com/user-attachments/assets/b0a694a0-f7ea-45ec-940c-27c0adfc1de0" />
</div>

3. Rename the created `CinemachienCamera` to `First-person Camera`.

<div>
  <img width="363" height="214" alt="image" src="https://github.com/user-attachments/assets/7ce72f0f-76d9-413b-b273-fdf6b04a16e9" />
</div>

4. Drag the `First-person Camera` game object into the `Player Camera` game object.

<div>
  <img width="363" height="214" alt="image" src="https://github.com/user-attachments/assets/7284c185-dd85-4a49-86fd-98fdb91675b6" />
</div>

5. In the hierarchy menu, click on the `First-person Camera` game object.

<div>
  <img width="365" height="216" alt="image" src="https://github.com/user-attachments/assets/60649942-6d53-4d5a-b1ca-c0da2b481968" />
</div>

6. From the hierarchy menu, drag the `Y Bot` game object into the `Tracking Target` within the `Cinemachine Camera` component of the `First-person Camera` game object.

<div>
  <img width="454" height="352" alt="image" src="https://github.com/user-attachments/assets/f7d448d3-f7c8-409b-aa72-89b6fcbe1f37" />
</div>

7. Enter the values shown below into the `Cinemachine Follow` component.

<div>
  <img width="454" height="87" alt="image" src="https://github.com/user-attachments/assets/ab9f05a4-69f6-4f4c-9535-6c204252a6df" />
</div>

8. Enter the values shown below into the `Cinemachine Rotation Composer` component.

<div>
  <img width="454" height="225" alt="image" src="https://github.com/user-attachments/assets/d9814eea-9e2e-4f9c-92a9-0d3370fa9831" />
</div>

### Step 3 - Scoped Camera

1. In the hierarchy menu, right-click on the `Player Camera` game object.

<div>
  <img width="364" height="213" alt="image" src="https://github.com/user-attachments/assets/2c580089-1727-4c3c-bd24-29b211fee68d" />
</div>

2. Click on `Cinemachine > Targeted Cameras > Follow Camera`.

<div>
  <img width="364" height="229" alt="image" src="https://github.com/user-attachments/assets/8cd95283-872a-4e51-9956-27979a4debc9" />
</div>

3. Rename the created `CinemachineCamera` to `Scoped Camera`.

<div>
  <img width="364" height="229" alt="image" src="https://github.com/user-attachments/assets/433d18f1-c5d4-4cfd-806a-377afc08f157" />
</div>

4. Drag the `Scoped Camera` game object into the `Player Camera` game object.

<div>
  <img width="364" height="229" alt="image" src="https://github.com/user-attachments/assets/c8f2050e-80cf-436f-a68c-fd8113f8d75b" />
</div>

5. In the hierarchy menu, click on the `Scoped Camera` game object.

<div>
  <img width="364" height="229" alt="image" src="https://github.com/user-attachments/assets/bf0d4c46-1267-456d-9b9e-9045f52c2385" />
</div>

6. In the hierarchy menu, look for the `m1garand` game object within the `Y Bot` game object.

<div>
  <img width="364" height="507" alt="image" src="https://github.com/user-attachments/assets/9283bdf9-555a-4aba-9c5f-29cea1a6d59c" />
</div>

7. From the hierarchy menu, drag the `m1garand` game object into the `Tracking Target` within the `Cinemachine Camera` component of the `Scoped Camera` game object.

<div>
  <img width="453" height="351" alt="image" src="https://github.com/user-attachments/assets/54f5dea2-3d40-4765-a3e9-e04713251a79" />
</div>

8. Enter the values shown below into the `Cinemachine Camera` component.

<div>
  <img width="454" height="350" alt="image" src="https://github.com/user-attachments/assets/6a5c51c1-1ddc-40ea-8cda-c03873087554" />
</div>

9. Enter the values shown below into the `Cinemachine Follow` component.

<div>
  <img width="453" height="129" alt="image" src="https://github.com/user-attachments/assets/13e41078-19b1-4ba5-9e7f-1c1dcf4456c3" />
</div>

10. Enter the values shown below into the `Cinemachine Rotation Composer` component.

<div>
  <img width="453" height="226" alt="image" src="https://github.com/user-attachments/assets/c66fc6c1-4de9-47ed-8469-80279382a905" />
</div>

### Step 4 - Animation State Cameras

1. In the hierarchy menu, click on the `Player Camera` game object.

<div>
  <img width="365" height="226" alt="image" src="https://github.com/user-attachments/assets/a5d9550a-6c24-4e76-a2d4-d1dc750448dd" />
</div>

2. From the hierarchy menu, drag the `Y Bot` game object into `Animated Target` within the `Cinemachine State Driven Camera` component in the inspector menu.

<div>
  <img width="454" height="544" alt="image" src="https://github.com/user-attachments/assets/665d2754-b66a-415e-80c7-87454634da6a" />
</div>

3. In the inspector menu, open the `Layer Index` dropdown in the `Cinemachine State Driven Camera` component and select `Aim Layer`.

<div>
  <img width="454" height="59" alt="image" src="https://github.com/user-attachments/assets/eb26b485-a81b-4b28-a727-72ebec6628a5" />
</div>

4. In the inspector menu, add four empty instructions under `Instructions` in the `Cinemachine State Driven Camera` component.

<div>
  <img width="454" height="259" alt="image" src="https://github.com/user-attachments/assets/3abf95ec-5a77-4fee-af88-3e1c3228c165" />
</div>

5. Enter the values shown below into `Instructions` within the `Cinemachine State Driven Camera` component.

<div>
  <img width="454" height="259" alt="image" src="https://github.com/user-attachments/assets/f1712db3-54f1-46a7-862f-4c5b326e622c" />
</div>

6. Enter play mode to see the first-person camera, then hold the right mouse button to see the scoped camera. Exit play mode when you're done.

> [!NOTE]
> You might need to disable the `Cinemachine Sequencer Camera` component of the `Cutscene Camera` game object.
>
> <img width="454" height="246" alt="image" src="https://github.com/user-attachments/assets/6eafc41c-a2b7-4a61-9b45-5bc71d095116" />
>
> Make sure to enable the component again after exiting play mode.

## Chapter 4 - Cutscene to Player Camera Switch

### Step 1 - Switching Code

1. In the project menu, go to `Assets/Scripts` and open the `CameraManager` script in your IDE of choice.
2. Add the following fields to the script:

```cs
[SerializeField] private CinemachineSequencerCamera cutsceneCamera;
[SerializeField] private CinemachineVirtualCameraBase playerCamera;

private int CutsceneInstructionCount => cutsceneCamera.Instructions.Count;
private int _cutsceneCutAndBlendsAmount;
```

3. Add the following method to the script:

```cs
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
```

> [!NOTE]
> Your `CameraManager` script should look something like the following after following the steps above:
> ```cs
> using Unity.Cinemachine;
> using UnityEngine;
> 
> [DisallowMultipleComponent]
> public class CameraManager : MonoBehaviour
> {
>     [SerializeField] private PlayerMovement playerMovement;
>     [SerializeField] private CinemachineSequencerCamera cutsceneCamera;
>     [SerializeField] private CinemachineVirtualCameraBase playerCamera;
>
>     private int CutsceneInstructionCount => cutsceneCamera.Instructions.Count;
>     private int _cutsceneCutAndBlendsAmount;
>
>     private void Start()
>     {
>         playerMovement.enabled = false;
>     }
>
>     public void OnCutOrBlendFinished()
>     {
>         _cutsceneCutAndBlendsAmount++;
>         if (_cutsceneCutAndBlendsAmount >= CutsceneInstructionCount)
>         {
>             cutsceneCamera.enabled = false;
>             playerCamera.enabled = true;
>             playerMovement.enabled = true;
>         }
>     }
> }
> ```

### Step 2 - Camera Events

1. In the hierarchy menu, click on the `Camera Manager` game object.

<div>
  <img width="322" height="147" alt="image" src="https://github.com/user-attachments/assets/799f139a-5206-41e7-aec6-de5a6e37585d" />
</div>

2. Drag the `Cutscene Camera` game object into the `Cutscene Camera` field in the `Camera Manager (Script)` script in the `Camera Manager` game object.

<div>
  <img width="454" height="113" alt="image" src="https://github.com/user-attachments/assets/b0ebf223-8dc1-4c7b-a1b5-dcb6482850f6" />
</div>

3. Drag the `Player Camera` game object into the `Player Camera` field in the `Camera Manager (Script)` script in the `Camera Manager` game object.

<div>
  <img width="454" height="113" alt="image" src="https://github.com/user-attachments/assets/4da93d17-1284-4958-a2dd-1421cf4c80d8" />
</div>

4. In the inspector menu, click on `Add Component`.

<div>
  <img width="454" height="285" alt="image" src="https://github.com/user-attachments/assets/6c3a8687-e7de-458c-b313-a837d96f60a1" />
</div>

5. Search for `Cinemachine Camera Manager Events` and add it to the game object.

<div>
  <img width="454" height="674" alt="image" src="https://github.com/user-attachments/assets/7ef2a64b-0219-45ea-a224-314320b5d6e1" />
</div>

6. Click on the `➕` on the `Blend Finished Event (ICinemachineMixer, ICinemachineCamera)` event.

<div>
  <img width="454" height="451" alt="image" src="https://github.com/user-attachments/assets/cba7be4f-7e32-499b-919a-772f37f723a3" />
</div>

7. Drag the `Camera Manager` game object into the `None (Object)` field of the `Blend Finished Event (ICinemachineMixer, ICinemachineCamera)` event.

<div>
  <img width="454" height="451" alt="image" src="https://github.com/user-attachments/assets/a424834d-a317-4895-9427-20d1d878f9f8" />
</div>

8. Click on the `No Function` dropdown of the `Blend Finished Event (ICinemachineMixer, ICinemachineCamera)` event and select `CameraManager > OnBlendOrCutFinished ()`.

<div>
  <img width="454" height="451" alt="image" src="https://github.com/user-attachments/assets/09897145-8ae4-48f6-bb99-0b2aafed9809" />
</div>

9. Click on the `➕` on the `Camera Cut Event (ICinemachineMixer, ICinemachineCamera)` event.

<div>
  <img width="454" height="472" alt="image" src="https://github.com/user-attachments/assets/02a2a19e-4016-4daf-8980-edf3cfe60e45" />
</div>

10. Drag the `Camera Manager` game object into the `None (Object)` field of the `Camera Cut Event (ICinemachineMixer, ICinemachineCamera)` event.

<div>
  <img width="454" height="472" alt="image" src="https://github.com/user-attachments/assets/01509bea-2bc0-4d54-844c-738e2f16d8b6" />
</div>

11. Click on the `No Function` dropdown of the `Camera Cut Event (ICinemachineMixer, ICinemachineCamera)` event and select `CameraManager > OnBlendOrCutFinished ()`.

<div>
  <img width="454" height="472" alt="image" src="https://github.com/user-attachments/assets/87ccbe92-4385-416a-acc5-f3e196bb5f5a" />
</div>

12. Enter play mode to see the game switch from the cutscene to the first-person perspective and exit play mode when you're done.

## Chapter 5 - Movement Screenshake

### Step 1 - Screenshake Code

1. In the project menu, go to `Assets/Scripts` and open the `CameraController` script in your IDE of choice.
2. Add the following fields to the script:

```cs
[SerializeField] private CinemachineBasicMultiChannelPerlin noiseCamera;
[SerializeField, Min(0f)] private float transitionSpeed = 5f;

[Header("Target Amplitude")]
[SerializeField, Min(0f)] private float walkingTargetAmplitude = 0.5f;
[SerializeField, Min(0f)] private float sprintingTargetAmplitude = 2f;

[Header("Target Frequency")]
[SerializeField, Min(0f)] private float walingTargetFrequency = 1f;
[SerializeField, Min(0f)] private float sprintingTargetFrequency = 1.5f;

private float TargetAmplitude => _playerController.IsSprinting ? sprintingTargetAmplitude : walkingTargetAmplitude;
private float TargetFrequency => _playerController.IsSprinting ? sprintingTargetFrequency : walingTargetFrequency;
```

3. Add the following method to the script:

```cs
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
```

> [!NOTE]
> Your `CameraController` script should look something like the following after following the steps above:
> ```cs
> using Unity.Cinemachine;
> using UnityEngine;
> 
> [RequireComponent(typeof(PlayerController))]
> public class CameraController : MonoBehaviour
> {
>     [SerializeField] private CinemachineBasicMultiChannelPerlin noiseCamera;
>     [SerializeField, Min(0f)] private float transitionSpeed = 5f;
> 
>     [Header("Target Amplitude")]
>     [SerializeField, Min(0f)] private float walkingTargetAmplitude = 0.5f;
>     [SerializeField, Min(0f)] private float sprintingTargetAmplitude = 2f;
> 
>     [Header("Target Frequency")]
>     [SerializeField, Min(0f)] private float walingTargetFrequency = 1f;
>     [SerializeField, Min(0f)] private float sprintingTargetFrequency = 1.5f;
> 
>     private PlayerController _playerController;
> 
>     private float TargetAmplitude => _playerController.IsSprinting ? sprintingTargetAmplitude : walkingTargetAmplitude;
>     private float TargetFrequency => _playerController.IsSprinting ? sprintingTargetFrequency : walingTargetFrequency;
> 
>     private void Awake()
>     {
>         _playerController = GetComponent<PlayerController>();
>     }
> 
>     private void Update()
>     {
>         if (!noiseCamera) return;
> 
>         noiseCamera.AmplitudeGain = Mathf.Lerp(
>             noiseCamera.AmplitudeGain,
>             TargetAmplitude,
>             Time.deltaTime * transitionSpeed);
>         noiseCamera.FrequencyGain = Mathf.Lerp(
>             noiseCamera.FrequencyGain,
>             TargetFrequency,
>             Time.deltaTime * transitionSpeed);
>     }
> }
> ```

### Step 2 - Add Screenshake to First-Person Camera

1. In the hierarchy menu, click on the `First-person Camera` game object within the `Player Camera` game object.

<div>
  <img width="321" height="279" alt="image" src="https://github.com/user-attachments/assets/53a1d71a-dc2f-4732-ba60-ccfe763cbd33" />
</div>

2. In the inspector menu, click on `Add Component`.

<div>
  <img width="454" height="885" alt="image" src="https://github.com/user-attachments/assets/dd5f0e46-a992-4902-acb9-0fb592ecb79f" />
</div>

3. Search for `Cinemachine Basic Multi Channel Perlin` and add it to the camera.

<div>
  <img width="454" height="173" alt="image" src="https://github.com/user-attachments/assets/26980614-81eb-4310-8255-1e294a662182" />
</div>

4. Click on the cogwheel to the right of `Noise Profile` in the `Cinemachine Basic Mutli Channel Perlin` component of the `First-person Camera` game object.

<div>
  <img width="454" height="173" alt="image" src="https://github.com/user-attachments/assets/311c41b9-99b4-4362-b8b4-b9731b5fd5c9" />
</div>

5. Click on `Presets > Handheld_normal_mild`.

<div>
  <img width="454" height="132" alt="image" src="https://github.com/user-attachments/assets/32cd2ce3-c104-4923-aa82-c06dc33340d6" />
</div>

6. In the hierarchy menu, click on the `Y Bot` game object.

<div>
  <img width="322" height="272" alt="image" src="https://github.com/user-attachments/assets/03873f8d-e59e-48dc-a138-19c643395293" />
</div>

7. Drag the `First-person Camera` game object into `Noise Camera` of the `Camera Controller (Script)` script of the `Y Bot` game object.

<div>
  <img width="451" height="231" alt="image" src="https://github.com/user-attachments/assets/c83fd739-c289-4d3d-b12a-58677644ad17" />
</div>

8. Enter play mode and press shift while moving the player with WASD to see the screen shake and exit when you're done.

> [!NOTE]
> You'll need to wait for the cutscene to finish before you can start moving the player.
