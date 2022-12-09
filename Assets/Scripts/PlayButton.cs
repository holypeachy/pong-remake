using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
