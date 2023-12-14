using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelUpSystem
{
    private PlayerLevelUpComponent playerLevelUpComponent = new PlayerLevelUpComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        // gameEvent.LevelUp = LevelUp;
    }

    public void AddExperiencePoint(int experience)
    {
        playerLevelUpComponent.ExperiencePoint += experience;
        if (playerLevelUpComponent.ExperiencePoint >= playerLevelUpComponent.LevelUpBorder)
        {
            playerLevelUpComponent.ExperiencePoint -= playerLevelUpComponent.LevelUpBorder;
            playerLevelUpComponent.IsLevelUp = true;
        }
    }

    public void AttackUp()
    {
        if (playerLevelUpComponent.IsLevelUp)
        {
            playerLevelUpComponent.AttackLevel++;
            playerLevelUpComponent.IsLevelUp = false;
        }
    }

    public void ShotSpeedUp()
    {
        if (playerLevelUpComponent.IsLevelUp)
        {
            playerLevelUpComponent.ShotSpeedLevel++;
            playerLevelUpComponent.IsLevelUp = false;
        }
    }

    public void HitPointUp()
    {
        if (playerLevelUpComponent.IsLevelUp)
        {
            playerLevelUpComponent.HitPointLevel++;
            playerLevelUpComponent.IsLevelUp = false;
        }
    }
}
