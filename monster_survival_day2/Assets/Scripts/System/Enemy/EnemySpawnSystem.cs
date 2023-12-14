using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSystem : MonoBehaviour
{
    private EnemySpawnComponent enemySpawnComponent = new EnemySpawnComponent();

    private GameEvent gameEvent;

    private float SPAWN_INTERVAL = 1.0f;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        enemySpawnComponent.SpawnInterval = SPAWN_INTERVAL;
    }

    public void OnUpdate()
    {
        enemySpawnComponent.SpawnTimer += Time.deltaTime;
        if (enemySpawnComponent.SpawnTimer < enemySpawnComponent.SpawnInterval) return;
        gameEvent.GenerateEnemy(new Vector3(1.0f, 0.0f, 1.0f));
        enemySpawnComponent.SpawnTimer = 0.0f;

    }
}
