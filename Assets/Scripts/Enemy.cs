using UnityEngine;

public class Enemy : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = 1f;
        }
        else if (Input.GetMouseButton(0))
        {
            movement = -1f;
        }
        else if (Input.GetMouseButton(1))
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
