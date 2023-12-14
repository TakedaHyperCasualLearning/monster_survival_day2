using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveSystem
{
    private BulletMoveComponent bulletMoveComponent = new BulletMoveComponent();
    private GameEvent gameEvent;
    private float SHOT_SPEED = 10.0f;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        gameEvent.SetBulletDirection = SetVelocity;

        bulletMoveComponent.Speed = SHOT_SPEED;
    }

    public void OnUpdate()
    {
        for (int i = 0; i < gameEvent.GetBulletPool().Count; i++)
        {
            BulletEntity bulletEntity = gameEvent.GetBulletPool()[i];
            if (!bulletEntity.BulletObject.activeSelf) continue;

            Vector3 velocity = bulletMoveComponent.Velocity.normalized * bulletMoveComponent.Speed;
            velocity.y = 0.0f;
            bulletMoveComponent.Velocity = velocity;

            bulletEntity.BulletObject.transform.Translate(bulletMoveComponent.Velocity * Time.deltaTime, Space.World);
        }
    }

    public void SetVelocity(Vector3 velocity)
    {
        bulletMoveComponent.Velocity = velocity;
    }
}
