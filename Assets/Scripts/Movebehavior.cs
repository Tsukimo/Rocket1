using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Movebehavior : MonoBehaviour
{

    public float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("pipePart"))
        {
            GameManager.instance.Lose();
        }
    }

}
