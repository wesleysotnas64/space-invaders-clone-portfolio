using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Vector2 direction;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        direction = speed * Time.deltaTime * direction.normalized;
        transform.Translate(direction.x, direction.y, 0);

        direction = Vector2.zero;
    }

    public void LeftMove()
    {
        direction += Vector2.left;
    }

    public void RightMove()
    {
        direction += Vector2.right;
    }

}
