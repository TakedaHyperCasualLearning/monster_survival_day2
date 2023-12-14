using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotComponent : MonoBehaviour
{
    private float shotInterval = 0.0f;
    private float shotTimer = 0.0f;

    public float ShotInterval { set => shotInterval = value; get => shotInterval; }
    public float ShotTimer { set => shotTimer = value; get => shotTimer; }
}
