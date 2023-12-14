using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageComponent
{
    private List<int> hitPointList = new List<int>();
    private int hitPointMax = 0;

    public List<int> HitPointList { set => hitPointList = value; get => hitPointList; }
    public int HitPointMax { set => hitPointMax = value; get => hitPointMax; }
}
