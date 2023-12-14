using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSystem
{
    private PlayerEntity playerEntity;
    private PlayerMoveComponent playerMoveComponent;
    private GameEvent gameEvent;

    private float MOVE_SPEED = 5.0f;

    public void Initialize(PlayerEntity playerEntity, GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;

        gameEvent.GetGameObjectPlayer = () => playerEntity.PlayerObject;

        this.playerEntity = playerEntity;

        playerMoveComponent = new PlayerMoveComponent()
        {
            Velocity = Vector3.zero,
            Speed = MOVE_SPEED
        };
    }

    public void OnUpdate()
    {
        Vector3 resultVector = gameEvent.GetInputMove();
        if (resultVector == Vector3.zero) return;
        playerMoveComponent.Velocity = resultVector.normalized;
        playerEntity.PlayerObject.transform.Translate(playerMoveComponent.Velocity * playerMoveComponent.Speed * Time.deltaTime, Space.Self);
    }
}
