using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float time = 3f;
    public float countDownTime;
    
    
    public GameObject pumpkinPrefab;
    public Transform ghostSpawn;

    void Update()
    {
        ShootingTime();
    }

    void ShootingTime()
    {
        countDownTime -= Time.deltaTime;
        if (countDownTime < 0)
        {
            ResetCountDown();
            InstPumpkin();
        }
    }

    void ResetCountDown()
    {
        countDownTime = time;
    }

    void InstPumpkin()
    {
        Instantiate(pumpkinPrefab, ghostSpawn.position, transform.rotation);
    }
    
}
