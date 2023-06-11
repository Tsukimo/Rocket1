using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] public GameObject LoseWindow;

    // Start is called before the first frame update
    private void Start()
    {
        instance = this;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        LoseWindow.SetActive(true);
        Time.timeScale = 0;
    }
}
