using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotSystem : MonoBehaviour
{
    private GameEvent gameEvent;
    private PlayerShotComponent playerShotComponent = new PlayerShotComponent();

    private void Start()
    {
        gameEvent = GetComponent<GameEvent>();
    }

    private void Update()
    {
        if (gameEvent.GetInputMouse() == Vector3.zero) return;

    }
}
