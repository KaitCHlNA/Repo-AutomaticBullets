using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    private float horMove;
    //public float verMove;
    
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horMove = Input.GetAxis("Horizontal");
        //verMove = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(0, 0 , horMove) * playerSpeed * Time.deltaTime);
    }
}
