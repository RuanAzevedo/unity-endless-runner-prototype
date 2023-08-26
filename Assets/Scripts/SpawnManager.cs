using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    private Vector3 spawnPos = new(25, 0, 0);
    private readonly float startDelay = 2;
    private readonly float repeatRate = 2;
    private PlayerController playerControllerScript;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
