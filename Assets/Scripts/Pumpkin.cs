using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public float pumpkinSpeed = 4f;
    public Vector3 shootingDirection;
    public float destructionTime;
    
    void Update()
    {
        Move();
        IncreaseSize();
    }

    void Move()
    {
        transform.position += pumpkinSpeed * shootingDirection * Time.deltaTime;
        Destroy(gameObject, destructionTime);
    }

    void IncreaseSize()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += new Vector3(1,1,1);
        }
    }
}
