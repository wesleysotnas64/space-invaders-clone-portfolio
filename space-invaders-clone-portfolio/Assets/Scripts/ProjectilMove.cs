using UnityEngine;

public class ProjectilMove : MonoBehaviour
{
    public float speed;
    public Vector2 direction;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        direction = speed*Time.deltaTime*transform.up;
        transform.Translate(direction.x, direction.y, 0);
    }
}
