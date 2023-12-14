using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputSystem : MonoBehaviour
{
    public void Initialize(GameEvent gameEvent)
    {
        gameEvent.GetInputMouse = MouseClickInput;
        gameEvent.GetInputMove = MoveInput;
    }
    public Vector3 MoveInput()
    {
        if (Input.GetKey(KeyCode.W)) { return new Vector3(0, 0, 1); }
        else if (Input.GetKey(KeyCode.S)) { return new Vector3(0, 0, -1); }
        else if (Input.GetKey(KeyCode.A)) { return new Vector3(-1, 0, 0); }
        else if (Input.GetKey(KeyCode.D)) { return new Vector3(1, 0, 0); }
        else { return Vector3.zero; }
    }

    public Vector3 MouseClickInput()
    {
        if (Input.GetMouseButtonDown(0)) { return Input.mousePosition; }
        else { return Vector3.zero; }
    }
}
