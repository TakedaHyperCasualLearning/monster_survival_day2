using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShotSystem : MonoBehaviour
{
    private BulletShotComponent bulletShotComponent = new BulletShotComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        gameEvent.ShotBullet = ShotBullet;
    }

    public void ShotBullet(Vector3 position, Vector3 direction)
    {
        gameEvent.GenerateBullet(position);
        gameEvent.SetBulletDirection(direction);
    }
}
