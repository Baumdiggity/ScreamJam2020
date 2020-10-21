using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public bool canMove = true;

    Rigidbody2D _body;

    Vector2 lookDirection = new Vector2(1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

            Vector2 position = _body.position;

            position.x = position.x + speed * direction.x * Time.deltaTime;
            position.y = position.y + speed * direction.y * Time.deltaTime;

            _body.MovePosition(position);
        }
    }

    public void SetMove(bool b)
    {
        canMove = b;
    }
}