using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody ghost;
    public Transform[] pointsPositions;
    public float enemySpeed = 40f;

    private int actualPoint = 0;
    private int nextPoint = 1;
    
    void Update()
    {
        GhostyMove();
    }

    void GhostyMove()
    {
        ghost.MovePosition(Vector3.MoveTowards(ghost.position, pointsPositions[nextPoint].position, enemySpeed * Time.deltaTime));

        if (Vector3.Distance(ghost.position, pointsPositions[nextPoint].position) <= 0)
        {
            actualPoint = nextPoint;
            nextPoint++;

            if (nextPoint > pointsPositions.Length - 1)
            {
                nextPoint = 0;
            }
        }
    }

    
}
