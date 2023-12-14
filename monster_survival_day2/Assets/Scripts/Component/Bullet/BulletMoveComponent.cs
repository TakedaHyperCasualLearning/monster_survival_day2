using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveComponent
{
    private Vector3 velocity;
    private float speed;


    public Vector3 Velocity { set => velocity = value; get => velocity; }
    public float Speed { set => speed = value; get => speed; }
}
