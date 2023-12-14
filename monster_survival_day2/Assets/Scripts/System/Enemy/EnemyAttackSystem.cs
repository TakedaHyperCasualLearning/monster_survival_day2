using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackSystem
{
    private EnemyAttackComponent enemyAttackComponent = new EnemyAttackComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        enemyAttackComponent.Attack = 5;
    }

    public void OnUpdate()
    {
        for (int i = 0; i < gameEvent.GetEnemyPool().Count; i++)
        {

            EnemyEntity enemyEntity = gameEvent.GetEnemyPool()[i];
            if (!enemyEntity.EnemyObject.activeSelf) continue;


            Vector3 playerPosition = gameEvent.GetGameObjectPlayer().transform.position;
            float playerRadius = gameEvent.GetGameObjectPlayer().transform.localScale.x / 2.0f;
            if (gameEvent.HitSphereCollision(playerPosition, enemyEntity.EnemyObject.transform.position, playerRadius, enemyEntity.EnemyObject.transform.localScale.x / 2.0f))
            {
                gameEvent.PlayerDamage(enemyAttackComponent.Attack);
            }
        }
    }
}
