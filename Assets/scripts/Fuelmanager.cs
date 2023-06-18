using System.Collections;
using UnityEngine;

public class Fuelmanager : MonoBehaviour
{
    [SerializeField] private float fuelSize;
    [SerializeField] private float fuelUsage;
    private float currentFuel;
    [SerializeField] private GameObject fuelProgressBar;

    void Start()
    {
        currentFuel = fuelSize;
        StartCoroutine(Fuel());
    }
    private void Update()
    {
        fuelProgressBar.transform.localScale = new Vector2(1, currentFuel / fuelSize);
    }

    void FixedUpdate()
    {
        if(currentFuel <= 0)
        {
            GameManager.instance.Lose();
        }
    }

    public IEnumerator Fuel()
    {
        yield return new WaitForSeconds(0.01f);
        while (true)
        {
            currentFuel -= fuelUsage;
            print(currentFuel);
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fuel"))
        {
            Destroy(other.gameObject);
            currentFuel = fuelSize;
        }
    }
}
