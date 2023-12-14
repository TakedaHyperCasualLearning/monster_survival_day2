using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSystem
{
    ColliderComponent colliderComponent = new ColliderComponent();
    GameEvent gameEvent;

    public void Initialize(GameEvent gameEvent)
    {
        this.gameEvent = gameEvent;
        gameEvent.HitSphereCollision = HitSphereToSphere;
        gameEvent.HitEdgeCollision = HitSphereToEdge;
        colliderComponent.BaseScreenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
    }

    public bool HitSphereToSphere(Vector3 position1, Vector3 position2, float radius1, float radius2)
    {
        Vector3 distance = position1 - position2;
        float distanceLength = distance.magnitude;
        float hitLength = radius1 + radius2;

        if (distanceLength <= hitLength) return true;
        return false;
    }


    public Vector3 HitSphereToEdge(Vector3 position, float radius)
    {
        Vector3 result = new Vector2(0.0f, 0.0f);
        float left = position.x - radius;
        float right = position.x + radius;
        float front = position.z + radius;
        float back = position.z - radius;
        Vector3 cameraPosition = Camera.main.transform.position;

        if (left < cameraPosition.x - colliderComponent.BaseScreenPosition.x) result += Vector3.right;
        if (right > cameraPosition.x + colliderComponent.BaseScreenPosition.x) result += Vector3.left;
        if (front > cameraPosition.z + colliderComponent.BaseScreenPosition.y) result += Vector3.back;
        if (back < cameraPosition.z - colliderComponent.BaseScreenPosition.y) result += Vector3.forward;

        return result.normalized;
    }


}
