using UnityEngine;
using System.Collections;
using TMPro;

public class Move : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minX;
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private int ScorePoint;
    private Vector2 _screenBounds;
    private float _objectWidth;
    private float _objectHeight;

    private void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        _rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(Score());
    }

    private void Update()
    {
        GetBorders();

    }

    private void FixedUpdate()
    {
        MoveRocket();
    }
    public void GetBorders()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x * -1 + _objectWidth, _screenBounds.x - _objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y * -1 + _objectHeight, _screenBounds.y - _objectHeight);
        transform.position = viewPos;
    }

    public void MoveRocket()
    {
        var velocity = new Vector2(Input.GetAxis("Horizontal") * _speed * Time.fixedDeltaTime, 0f);
        _rigidbody.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("pipePart"))
        {
            GameManager.instance.Lose();
        }
    }

    public IEnumerator Score()
    {
        yield return new WaitForSeconds(0.01f);
        while (true)
        {
            ScorePoint += 1;
            text.text = "Score: " + ScorePoint;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
