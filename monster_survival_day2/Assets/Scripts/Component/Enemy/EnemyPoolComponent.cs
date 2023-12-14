using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolComponent
{
    private List<EnemyEntity> enemyPool = new List<EnemyEntity>();
    private int enemyActiveCount = 0;

    public List<EnemyEntity> EnemyPool { set => enemyPool = value; get => enemyPool; }
    public int EnemyActiveCount { set => enemyActiveCount = value; get => enemyActiveCount; }
}
