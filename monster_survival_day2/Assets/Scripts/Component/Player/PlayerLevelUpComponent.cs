using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelUpComponent : MonoBehaviour
{
    private int experiencePoint;
    private int levelUpBorder;
    private int attackLevel;
    private int shotSpeedLevel;
    private int hitPointLevel;
    private bool isLevelUp;

    public int ExperiencePoint { set => experiencePoint = value; get => experiencePoint; }
    public int LevelUpBorder { set => levelUpBorder = value; get => levelUpBorder; }
    public int AttackLevel { set => attackLevel = value; get => attackLevel; }
    public int ShotSpeedLevel { set => shotSpeedLevel = value; get => shotSpeedLevel; }
    public int HitPointLevel { set => hitPointLevel = value; get => hitPointLevel; }
    public bool IsLevelUp { set => isLevelUp = value; get => isLevelUp; }
}
