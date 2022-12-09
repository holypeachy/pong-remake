using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObject userScore;

    private Score score;

    private void Start()
    {
        score = userScore.GetComponent<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            score.IncreaseScore();
        }
    }
}
