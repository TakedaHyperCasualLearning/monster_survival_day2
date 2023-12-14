using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    [SerializeField] private PlayerEntity playerEntity;
    private PlayerMoveComponent playerMoveComponent;

    void Start()
    {
        GameObject entity = new GameObject("PlayerEntity");
        playerMoveComponent = GetComponent<PlayerMoveComponent>();
    }

    void Update()
    {
        playerMoveComponent.Velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}
