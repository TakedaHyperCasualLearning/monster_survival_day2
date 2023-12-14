using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationSystem
{
    private PlayerEntity playerEntity;

    public void Initialize(PlayerEntity playerEntity)
    {
        this.playerEntity = playerEntity;
    }


    public void OnUpdate()
    {
        // Vector3 mousePosition = Input.mousePosition;
        // mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        // if (mousePosition == Vector3.zero) return;
        // playerEntity.PlayerObject.transform.LookAt(mousePosition);

        var screenPos = Camera.main.WorldToScreenPoint(playerEntity.PlayerObject.transform.position);
        var direction = Input.mousePosition - screenPos;
        var angle = GetAim(Vector3.zero, direction);
        playerEntity.PlayerObject.transform.localEulerAngles = new Vector3(0, -angle + 90, 0);
    }

    public float GetAim(Vector2 from, Vector2 to)
    {
        float dx = to.x - from.x;
        float dy = to.y - from.y;
        float rad = Mathf.Atan2(dy, dx);
        return rad * Mathf.Rad2Deg;
    }
}
