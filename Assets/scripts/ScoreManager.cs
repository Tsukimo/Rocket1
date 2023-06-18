using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public static ScoreManager instanse;
    private int score;

    void Start()
    {
        if (instanse == null)
        {
            instanse = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "Coin: " + score.ToString();
    }
}
