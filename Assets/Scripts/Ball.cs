using UnityEngine;

public class Ball : MonoBehaviour
{
    //Speed of the ball
    [SerializeField] private float ballSpeedX = 3f;
    [SerializeField] private float ballSpeedY = 4f;

    //Variables that increase the speed of the ball as the game progresses
    [SerializeField] private float speedIncrease = 0.4f;
    [SerializeField] private float timeIncreaseCooldownTime = 3f;
    private float nextTimeOfIncrease = 0f;

    //Direction of the ball
    private float velocityX;
    private float velocityY;

    private Rigidbody2D Rigid;
    private AudioManager Audio;


    void Awake()
    {
        //Gets Rigidbody
        Rigid = GetComponent<Rigidbody2D>();
        Audio = GetComponent<AudioManager>();
        
        //Randomly -1 or 1 for each
        velocityX = Random.Range(0,2) == 0 ? -1 : 1;
        velocityY = Random.Range(0,2) == 0 ? -1 : 1;

        //Kick starts the ball
        Rigid.velocity = new Vector2(velocityX * ballSpeedX, velocityY * ballSpeedY);

        //Sets up the next time where the speed of tha ball increases
        nextTimeOfIncrease = Time.time + timeIncreaseCooldownTime;
    }


    private void FixedUpdate()
    {
        IncreaseSpeed();
    }


    private void IncreaseSpeed()
    {
        if (Time.time >= nextTimeOfIncrease)
        {
            if (Rigid.velocity.y < 0)
            {
                Rigid.velocity = new Vector2(Rigid.velocity.x, Rigid.velocity.y - speedIncrease);
            }
            if (Rigid.velocity.y > 0)
            {
                Rigid.velocity = new Vector2(Rigid.velocity.x, Rigid.velocity.y + speedIncrease);
            }

            nextTimeOfIncrease = Time.time + timeIncreaseCooldownTime;
            //Debug.Log("Y Velocity of the ball: " + Rigid.velocity.y);
            //Debug.Log("X Velocity of the ball: " + Rigid.velocity.x);
        }
    }

    //Sound
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Audio.Play("hit");
    }
}
