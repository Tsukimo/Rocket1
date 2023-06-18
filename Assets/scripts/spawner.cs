using UnityEngine;

public class spawner : MonoBehaviour
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
            GameObject Meteorite = Instantiate(PreFab, transform.position, Quaternion.identity);
            float rand = Random.Range(MinPosition, MaxPosition);
            Meteorite.transform.position = new Vector2(rand, 5);
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
