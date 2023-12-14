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
}
