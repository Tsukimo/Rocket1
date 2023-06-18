using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    public static CollectCoin instanse;
    [SerializeField] private TextMeshProUGUI _text;
    private int _coinValue = 1;

    void Start()
    {
        if(instanse == null)
        {
            instanse = this;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreManager.instanse.ChangeScore(_coinValue);
        }
    }
}
