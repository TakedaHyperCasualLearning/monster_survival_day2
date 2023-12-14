using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveSystem : MonoBehaviour
{
    private CameraMoveComponent cameraMoveComponent = new CameraMoveComponent();

    private CameraEntity cameraEntity;
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent, CameraEntity cameraEntity)
    {
        this.cameraEntity = cameraEntity;
        this.gameEvent = gameEvent;
        cameraMoveComponent.Speed = 5.0f;
    }

    public void OnUpdate()
    {
        Vector3 resultVector = gameEvent.GetInputMove();
        if (resultVector == Vector3.zero) return;
        cameraMoveComponent.Velocity = new Vector3(resultVector.x, resultVector.z, resultVector.y).normalized;
        cameraEntity.CameraObject.transform.Translate(cameraMoveComponent.Velocity * cameraMoveComponent.Speed * Time.deltaTime, Space.Self);
    }
}
