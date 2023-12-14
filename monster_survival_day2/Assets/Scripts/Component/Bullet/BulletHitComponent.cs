using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitComponent
{
    private int attack;
    private float radius;

    public int Attack { set => attack = value; get => attack; }
    public float Radius { set => radius = value; get => radius; }
}
