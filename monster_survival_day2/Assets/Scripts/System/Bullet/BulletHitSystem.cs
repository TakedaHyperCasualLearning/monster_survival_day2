using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitSystem
{
    private BulletHitComponent bulletHitComponent = new BulletHitComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        bulletHitComponent.Attack = 1;
        // gameEvent.GetPlayerAttack = GetPlayerAttack;
    }


    public void OnUpdate()
    {
        for (int i = 0; i < gameEvent.GetBulletPool().Count; i++)
        {
            BulletEntity bulletEntity = gameEvent.GetBulletPool()[i];
            bulletHitComponent.Radius = bulletEntity.BulletObject.transform.localScale.x / 2.0f;
            if (!bulletEntity.BulletObject.activeSelf) continue;

            // if (gameEvent.HitEdgeCollision(bulletEntity.BulletObject.transform.position, -bulletHitComponent.Radius) != Vector3.zero)
            // {
            //     gameEvent.ReleaseBullet(bulletEntity.BulletObject);
            //     continue;
            // }

            for (int j = 0; j < gameEvent.GetEnemyPool().Count; j++)
            {
                EnemyEntity enemyEntity = gameEvent.GetEnemyPool()[j];
                if (!enemyEntity.EnemyObject.activeSelf) continue;

                if (gameEvent.HitSphereCollision(bulletEntity.BulletObject.transform.position, enemyEntity.EnemyObject.transform.position, bulletHitComponent.Radius, enemyEntity.EnemyObject.transform.localScale.x / 2.0f))
                {
                    gameEvent.ReleaseBullet(bulletEntity.BulletObject);
                    gameEvent.EnemyDamage(j, bulletHitComponent.Attack);
                    break;
                }
            }
        }

    }

}
