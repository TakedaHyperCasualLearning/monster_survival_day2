using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveSystem : MonoBehaviour
{
    private EnemyMoveComponent enemyMoveComponent = new EnemyMoveComponent();
    private EnemyEntity enemyEntity;
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;

        enemyMoveComponent.Speed = 1.0f;
    }

    public void OnUpdate()
    {
        for (int i = 0; i < gameEvent.GetEnemyPool().Count; i++)
        {
            enemyEntity = gameEvent.GetEnemyPool()[i];
            if (!enemyEntity.EnemyObject.activeSelf) continue;

            Vector3 playerPosition = gameEvent.GetGameObjectPlayer().transform.position;

            Vector3 direction = playerPosition - enemyEntity.EnemyObject.transform.position;
            direction.Normalize();

            Vector3 velocity = direction * enemyMoveComponent.Speed;
            velocity.y = 0.0f;

            enemyMoveComponent.Velocity = velocity;

            enemyEntity.EnemyObject.transform.LookAt(playerPosition);
            enemyEntity.EnemyObject.transform.Translate(enemyMoveComponent.Velocity * Time.deltaTime, Space.World);
        }
    }
}
