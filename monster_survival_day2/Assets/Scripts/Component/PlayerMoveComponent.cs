using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveComponent
{
    private Vector3 velocity = Vector3.zero;
    private float speed = 0.0f;

    public Vector3 Velocity { set => velocity = value; get => velocity; }
    public float Speed { set => speed = value; get => speed; }
}
