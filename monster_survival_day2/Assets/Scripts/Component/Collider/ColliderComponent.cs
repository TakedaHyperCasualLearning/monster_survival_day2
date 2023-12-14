using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderComponent
{
    private Vector2 baseScreenPosition = new Vector2(0.0f, 0.0f);

    public Vector2 BaseScreenPosition { set => baseScreenPosition = value; get => baseScreenPosition; }
}
