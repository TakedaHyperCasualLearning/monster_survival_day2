using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject cameraObject;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject bulletPrefab;

    private GameEvent gameEvent = new GameEvent();

    private PlayerEntity playerEntity = new PlayerEntity();
    private PlayerMoveSystem playerMoveSystem = new PlayerMoveSystem();
    private PlayerInputSystem playerInputSystem = new PlayerInputSystem();
    private PlayerShotSystem playerShotSystem = new PlayerShotSystem();
    private PlayerRotationSystem playerRotationSystem = new PlayerRotationSystem();
    private PlayerDamageSystem playerDamageSystem = new PlayerDamageSystem();

    private CameraEntity cameraEntity = new CameraEntity();
    private CameraMoveSystem cameraMoveSystem = new CameraMoveSystem();

    private EnemyEntity enemyEntity = new EnemyEntity();
    private EnemyMoveSystem enemyMoveSystem = new EnemyMoveSystem();
    private EnemySpawnSystem enemySpawnSystem = new EnemySpawnSystem();
    private EnemyPoolSystem enemyPoolSystem = new EnemyPoolSystem();
    private EnemyAttackSystem enemyAttackSystem = new EnemyAttackSystem();
    private EnemyDamageSystem enemyDamageSystem = new EnemyDamageSystem();

    private BulletMoveSystem bulletMoveSystem = new BulletMoveSystem();
    private BulletPoolSystem bulletPoolSystem = new BulletPoolSystem();
    private BulletShotSystem bulletShotSystem = new BulletShotSystem();
    private BulletHitSystem bulletHitSystem = new BulletHitSystem();


    private ColliderSystem colliderSystem = new ColliderSystem();


    void Start()
    {
        playerEntity.PlayerObject = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        playerMoveSystem.Initialize(playerEntity, gameEvent);
        playerInputSystem.Initialize(gameEvent);
        playerShotSystem.Initialize(gameEvent);
        playerRotationSystem.Initialize(playerEntity);
        playerDamageSystem.Initialize(gameEvent);

        cameraEntity.CameraObject = cameraObject;
        cameraMoveSystem.Initialize(gameEvent, cameraEntity);
        enemyEntity.EnemyObject = enemyPrefab;
        enemyMoveSystem.Initialize(gameEvent);
        enemySpawnSystem.Initialize(gameEvent);
        enemyPoolSystem.Initialize(gameEvent, enemyPrefab);
        enemyAttackSystem.Initialize(gameEvent);
        enemyDamageSystem.Initialize(gameEvent);

        bulletMoveSystem.Initialize(gameEvent);
        bulletPoolSystem.Initialize(gameEvent, bulletPrefab);
        bulletShotSystem.Initialize(gameEvent);
        bulletHitSystem.Initialize(gameEvent);

        colliderSystem.Initialize(gameEvent);
    }

    void Update()
    {
        playerMoveSystem.OnUpdate();
        playerShotSystem.OnUpdate();
        playerRotationSystem.OnUpdate();
        playerDamageSystem.OnUpdate();

        cameraMoveSystem.OnUpdate();

        enemyMoveSystem.OnUpdate();
        enemySpawnSystem.OnUpdate();
        enemyAttackSystem.OnUpdate();

        bulletMoveSystem.OnUpdate();
        bulletHitSystem.OnUpdate();

    }
}
