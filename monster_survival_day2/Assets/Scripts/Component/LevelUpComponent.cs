using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpComponent
{
    private int attackLevel;
    private int shotSpeedLevel;
    private int hitPointLevel;

    public int AttackLevel { set => attackLevel = value; get => attackLevel; }
    public int ShotSpeedLevel { set => shotSpeedLevel = value; get => shotSpeedLevel; }
    public int HitPointLevel { set => hitPointLevel = value; get => hitPointLevel; }
}
