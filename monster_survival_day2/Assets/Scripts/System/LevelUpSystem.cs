using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpSystem
{
    private LevelUpComponent levelUpComponent = new LevelUpComponent();
    private GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        // gameEvent.LevelUp = LevelUp;
    }

    public void OnClickAttack()
    {

    }

}
