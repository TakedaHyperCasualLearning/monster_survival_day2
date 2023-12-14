using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent
{
    public Func<Vector3> GetInputMouse;
    public Func<Vector3> GetInputMove;
    public Func<GameObject> GetGameObjectPlayer;
    public Func<Vector3, GameObject> GenerateEnemy;
    public Action<GameObject> ReleaseEnemy;
    public Func<List<EnemyEntity>> GetEnemyPool;
    public Func<Vector3, GameObject> GenerateBullet;
    public Action<GameObject> ReleaseBullet;
    public Func<List<BulletEntity>> GetBulletPool;
    public Action<Vector3, Vector3> ShotBullet;
    public Action<Vector3> SetBulletDirection;
    public Func<Vector3, Vector3, float, float, bool> HitSphereCollision;
    public Func<Vector3, float, Vector3> HitEdgeCollision;
    public Action<int> PlayerDamage;
    public Action<int, int> EnemyDamage;
    public Func<bool> GetIsDead;
    public Func<int> GetPlayerAttack;
    public Func<float> GetPlayerShotSpeed;
    public Func<int> GetPlayerHitPoint;
}
