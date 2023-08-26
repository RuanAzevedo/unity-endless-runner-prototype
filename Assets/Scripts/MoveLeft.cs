using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    PlayerController playerController;
    private readonly float speed = 30;
    private readonly float leftBound = -15;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!playerController.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        bool isObstacle = gameObject.CompareTag("Obstacle");

        if (transform.position.x < leftBound && isObstacle)
        {
            Destroy(gameObject);
        }

    }
}
