using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerMoney : MonoBehaviour
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
            GameObject Coin = Instantiate(PreFab, transform.position, Quaternion.identity);
            float rand = Random.Range(MinPosition, MaxPosition);
            Coin.transform.position = new Vector2(rand, 5);
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
