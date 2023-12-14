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
    }

    public void OnUpdate()
    {
        cameraEntity.CameraObject.transform.position = gameEvent.GetGameObjectPlayer().transform.position + new Vector3(0.0f, 10.0f, 0.0f);
    }
}
