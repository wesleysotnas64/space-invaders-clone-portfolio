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
        transform.Translate(0, speed*Time.deltaTime, 0);

        if(transform.position.y > 10 || transform.position.y < -10) Destroy(gameObject);
    }
}
