using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotSystem : MonoBehaviour
{
    private GameEvent gameEvent;
    private PlayerShotComponent playerShotComponent = new PlayerShotComponent();
    private float SHOT_INTERVAL = 0.5f;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        playerShotComponent.ShotInterval = SHOT_INTERVAL;
    }


    public void OnUpdate()
    {
        if (playerShotComponent.ShotTimer <= playerShotComponent.ShotInterval)
        {
            playerShotComponent.ShotTimer += Time.deltaTime;
            return;
        }

        Vector3 mousePosition = gameEvent.GetInputMouse();
        if (mousePosition == Vector3.zero) return;
        Vector3 direction = gameEvent.GetGameObjectPlayer().transform.forward;
        gameEvent.ShotBullet(gameEvent.GetGameObjectPlayer().transform.position, direction);
        playerShotComponent.ShotTimer = 0.0f;
    }
}
