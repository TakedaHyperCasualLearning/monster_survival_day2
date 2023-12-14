using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyPoolSystem
{
    private EnemyPoolComponent enemyPoolComponent = new EnemyPoolComponent();
    private GameObject enemyObjectPrefab;

    public void Initialize(GameEvent gameEvent, GameObject enemyObject)
    {
        gameEvent.GenerateEnemy = Generate;
        gameEvent.ReleaseEnemy = Release;
        gameEvent.GetEnemyPool = GetEnemyEntityList;
        enemyObjectPrefab = enemyObject;
    }

    public GameObject Generate(Vector3 position)
    {
        if (enemyPoolComponent.EnemyActiveCount < enemyPoolComponent.EnemyPool.Count)
        {
            for (int i = 0; i < enemyPoolComponent.EnemyPool.Count; i++)
            {
                if (enemyPoolComponent.EnemyPool[i].EnemyObject.activeSelf) continue;
                enemyPoolComponent.EnemyPool[i].EnemyObject.SetActive(true);
                enemyPoolComponent.EnemyPool[i].EnemyObject.transform.position = position;
                enemyPoolComponent.EnemyActiveCount++;
                return enemyPoolComponent.EnemyPool[i].EnemyObject;
            }
            return null;
        }
        else
        {
            EnemyEntity enemyEntity = new EnemyEntity();
            GameObject enemyObject = GameObject.Instantiate(enemyObjectPrefab, position, Quaternion.identity);
            enemyEntity.EnemyObject = enemyObject;
            enemyObject.SetActive(true);
            enemyPoolComponent.EnemyPool.Add(enemyEntity);
            enemyPoolComponent.EnemyActiveCount++;
            return enemyObject;
        }
    }

    public void Release(GameObject enemyObject)
    {
        enemyObject.SetActive(false);
        enemyPoolComponent.EnemyActiveCount--;
    }

    public List<EnemyEntity> GetEnemyEntityList()
    {
        return enemyPoolComponent.EnemyPool;
    }
}
