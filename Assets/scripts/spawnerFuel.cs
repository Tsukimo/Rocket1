using UnityEngine;

public class spawnerFuel : MonoBehaviour
{
    [SerializeField] private float TimeToSpawn;
    [SerializeField] private float MinPosition, MaxPosition;
    [SerializeField] private GameObject PreFab;
    private float _timer;

    void Update()
    {
        if (_timer <= 0)
        {
            _timer = TimeToSpawn;
            GameObject Fuel = Instantiate(PreFab, transform.position, Quaternion.identity);
            float rand = Random.Range(MinPosition, MaxPosition);
            Fuel.transform.position = new Vector2(rand, 5);
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
