using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageSystem
{
    private EnemyDamageComponent enemyDamageComponent = new EnemyDamageComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        gameEvent.EnemyDamage = EnemyDamage;
        enemyDamageComponent.HitPointMax = 5;
    }

    public void EnemyDamage(int index, int attack)
    {
        if (index >= enemyDamageComponent.HitPointList.Count)
        {
            enemyDamageComponent.HitPointList.Add(enemyDamageComponent.HitPointMax);
        }

        enemyDamageComponent.HitPointList[index] -= attack;
        if (enemyDamageComponent.HitPointList[index] <= 0)
        {
            gameEvent.ReleaseEnemy(gameEvent.GetEnemyPool()[index].EnemyObject);
            enemyDamageComponent.HitPointList[index] = enemyDamageComponent.HitPointMax;
        }
    }

}
