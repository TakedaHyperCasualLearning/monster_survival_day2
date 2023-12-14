using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageSystem
{
    private PlayerDamageComponent playerDamageComponent = new PlayerDamageComponent();

    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        gameEvent.PlayerDamage = DamagePlayer;
        gameEvent.GetPlayerHitPoint = () => { return playerDamageComponent.HitPoint; };
        gameEvent.GetIsDead = () => { return playerDamageComponent.IsDead; };
        playerDamageComponent.HitPoint = 100;
        playerDamageComponent.MaxHitPoint = 100;
        playerDamageComponent.DamageInterval = 0.5f;
        playerDamageComponent.DamageTimer = 0.0f;
    }

    public void OnUpdate()
    {
        if (playerDamageComponent.IsDead) return;
        playerDamageComponent.DamageTimer += Time.deltaTime;
        if (playerDamageComponent.DamageTimer < playerDamageComponent.DamageInterval) return;
        playerDamageComponent.IsDamage = false;
    }

    public void DamagePlayer(int attack)
    {
        if (playerDamageComponent.IsDamage) return;
        playerDamageComponent.IsDamage = true;
        playerDamageComponent.DamageTimer = 0.0f;
        playerDamageComponent.HitPoint -= attack;
        Debug.Log("Player HitPoint: " + playerDamageComponent.HitPoint);
        if (playerDamageComponent.HitPoint <= 0)
        {
            playerDamageComponent.HitPoint = 0;
            playerDamageComponent.IsDead = true;
            gameEvent.GetGameObjectPlayer().SetActive(false);
        }
    }

}
