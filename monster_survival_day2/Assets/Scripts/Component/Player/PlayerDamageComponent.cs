using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageComponent
{
    private int hitPoint;
    private int maxHitPoint;
    private bool isDead;
    private float damageInterval = 0.0f;
    private float damageTimer = 0.0f;
    private bool isDamage = false;

    public int HitPoint { set => hitPoint = value; get => hitPoint; }
    public int MaxHitPoint { set => maxHitPoint = value; get => maxHitPoint; }
    public bool IsDead { set => isDead = value; get => isDead; }
    public float DamageInterval { set => damageInterval = value; get => damageInterval; }
    public float DamageTimer { set => damageTimer = value; get => damageTimer; }
    public bool IsDamage { set => isDamage = value; get => isDamage; }
}
