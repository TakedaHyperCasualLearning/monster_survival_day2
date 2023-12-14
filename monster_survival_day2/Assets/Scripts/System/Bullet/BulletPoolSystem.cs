using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolSystem
{
    private BulletPoolComponent bulletPoolComponent = new BulletPoolComponent();
    private GameObject bulletObjectPrefab;

    public void Initialize(GameEvent gameEvent, GameObject bulletObject)
    {
        gameEvent.GenerateBullet = Generate;
        gameEvent.ReleaseBullet = Release;
        gameEvent.GetBulletPool = GetBulletEntityList;
        bulletObjectPrefab = bulletObject;
    }

    public GameObject Generate(Vector3 position)
    {
        if (bulletPoolComponent.BulletActiveCount < bulletPoolComponent.BulletPool.Count)
        {
            for (int i = 0; i < bulletPoolComponent.BulletPool.Count; i++)
            {
                if (bulletPoolComponent.BulletPool[i].BulletObject.activeSelf) continue;
                bulletPoolComponent.BulletPool[i].BulletObject.SetActive(true);
                bulletPoolComponent.BulletPool[i].BulletObject.transform.position = position;
                bulletPoolComponent.BulletActiveCount++;
                return bulletPoolComponent.BulletPool[i].BulletObject;
            }
            return null;
        }
        else
        {
            BulletEntity bulletEntity = new BulletEntity();
            GameObject bulletObject = GameObject.Instantiate(bulletObjectPrefab, position, Quaternion.identity);
            bulletEntity.BulletObject = bulletObject;
            bulletObject.SetActive(true);
            bulletPoolComponent.BulletPool.Add(bulletEntity);
            bulletPoolComponent.BulletActiveCount++;
            return bulletObject;
        }
    }

    public void Release(GameObject enemyObject)
    {
        enemyObject.SetActive(false);
        bulletPoolComponent.BulletActiveCount--;
    }

    public List<BulletEntity> GetBulletEntityList()
    {
        return bulletPoolComponent.BulletPool;
    }
}
