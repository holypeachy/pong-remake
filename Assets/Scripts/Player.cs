using UnityEngine;

public class Player : MonoBehaviour
{
    //Movement Variables
    [SerializeField] private float movement;
    [SerializeField] private float speed = 8f;

    //Rigidbody
    private Rigidbody2D Rigid;


    private void Awake()
    {
        //Gets component
        Rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //User input
        //movement = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            movement = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = 1f;
        }
        else
        {
            movement = 0;
        }
    }


    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Rigid.velocity = new Vector2(movement * speed, 0);
    }
}
