using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject mainCamera;

    private Respawner respawner;

    public int scoreValue;

    private void Awake()
    {
        respawner = mainCamera.GetComponent<Respawner>();
    }

    private void Update()
    {
        scoreText.text = scoreValue.ToString();
    }

    public void IncreaseScore()
    {
        scoreValue++;
        respawner.Restart();
    }
}