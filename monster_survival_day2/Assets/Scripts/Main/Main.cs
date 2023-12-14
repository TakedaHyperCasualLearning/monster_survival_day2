using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private GameObject enemyPrefab;

    private GameEvent gameEvent = new GameEvent();

    private PlayerEntity playerEntity = new PlayerEntity();
    private PlayerMoveSystem playerMoveSystem = new PlayerMoveSystem();
    private PlayerInputSystem playerInputSystem = new PlayerInputSystem();

    private CameraEntity cameraEntity = new CameraEntity();
    private CameraMoveSystem cameraMoveSystem = new CameraMoveSystem();

    private EnemyEntity enemyEntity = new EnemyEntity();
    private EnemyMoveSystem enemyMoveSystem = new EnemyMoveSystem();
    private EnemySpawnSystem enemySpawnSystem = new EnemySpawnSystem();
    private EnemyPoolSystem enemyPoolSystem = new EnemyPoolSystem();


    void Start()
    {
        playerEntity.PlayerObject = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        playerMoveSystem.Initialize(playerEntity, gameEvent);
        playerInputSystem.Initialize(gameEvent);
        cameraEntity.CameraObject = cameraObject;
        cameraMoveSystem.Initialize(gameEvent, cameraEntity);
        enemyEntity.EnemyObject = enemyPrefab;
        enemyMoveSystem.Initialize(gameEvent);
        enemySpawnSystem.Initialize(gameEvent);
        enemyPoolSystem.Initialize(gameEvent, enemyPrefab);
    }

    void Update()
    {
        playerMoveSystem.OnUpdate();
        cameraMoveSystem.OnUpdate();
        enemyMoveSystem.OnUpdate();
        enemySpawnSystem.OnUpdate();
    }
}
