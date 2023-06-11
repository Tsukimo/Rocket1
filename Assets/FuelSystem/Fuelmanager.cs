using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuelmanager : MonoBehaviour
{

    [SerializeField] private Text FuelManager;
    private float fuelAmount;

    [SerializeField] public GameObject LoseWindow;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BurnFuel());
        fuelAmount = 100;
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        FuelManager.text = "Fuel: " + fuelAmount.ToString();

        if (fuelAmount <= 0)
        {
            LoseWindow.SetActive(true);
            Time.timeScale = 0;
        }
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && fuelAmount > 0)
        {
           StartCoroutine(BurnFuel());
        }

    }

    private IEnumerator BurnFuel()
    {
        for ( float i = fuelAmount; i >= 1; i++)
        {
            fuelAmount -= 0.1f;
            yield return new WaitForSeconds(1f);
        }
    }
    public static Fuelmanager instance;

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
