using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 _direction = Vector2.zero;

        if(Input.GetKey(KeyCode.A)) _direction += Vector2.left;
        if(Input.GetKey(KeyCode.D)) _direction += Vector2.right;

        _direction = speed * Time.deltaTime * _direction.normalized;
        transform.Translate(_direction.x, _direction.y, 0);
    }
}
