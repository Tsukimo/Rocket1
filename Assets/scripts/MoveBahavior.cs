using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    public Vector2 position;

    public bool isLeft { get; private set; } = false;
    public bool isRight { get; private set; } = false;

    private void KeyIsDown(Object sender)
    {
        if (Input.GetKey(KeyCode.A))
        {
            isLeft = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRight = true;
        }
    }
    private void KeyIsUp(Object sender)
    {
        if (Input.GetKey(KeyCode.A))
        {
            isLeft = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRight = false;
        }


    }

    public void ResetSystem()
    {
        isLeft = false;
        isRight = false;
    }

    public void MovementSystem()
    {
        if (isLeft)
        {
            position = new Vector2(transform.position.x * -_speed * Time.deltaTime, transform.position.y);
            transform.position = position;

        }
    }

}