using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject ball;

    private GameObject ballName;

    private GameObject[] respawns;

    public void Restart()
    {
        respawns = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject p in respawns)
        {
            Object.Destroy(p);
        }
        ballName = Instantiate(ball);
        ballName.name = "Ball";
        Instantiate(player);
        Instantiate(enemy);
    }
}
