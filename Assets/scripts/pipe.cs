using UnityEngine;

public class pipe : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }
}
