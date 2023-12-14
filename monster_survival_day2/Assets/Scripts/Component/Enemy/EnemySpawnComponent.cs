using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnComponent
{
    private float spawnInterval = 0.0f;
    private float spawnTimer = 0.0f;

    public float SpawnInterval { set => spawnInterval = value; get => spawnInterval; }
    public float SpawnTimer { set => spawnTimer = value; get => spawnTimer; }
}
