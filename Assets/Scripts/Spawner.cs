using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float TimeToSpawn;
    public float MinPosition, MaxPosition;
    public GameObject PreFab;
    private float _timer;


    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            timer = TimeToSpawn;
            GameObject Meteorite = Instantiate(PreFab, transform.position, Quaternion.identity);
            float rand = Random.Range(MinPosition, MaxPosition);
            Meteorite.transform.position = new Vector2(50, rand);


        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}
