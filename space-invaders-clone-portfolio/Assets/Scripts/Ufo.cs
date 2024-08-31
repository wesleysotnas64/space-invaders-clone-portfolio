using UnityEngine;

public class Ufo : MonoBehaviour
{
    public int health;
    public EnemyType type;
    public int direction;
    public float speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(direction*speed*Time.deltaTime, 0, 0);

        if(transform.position.x < -22 || transform.position.x > 22)
        {
            Destroy(gameObject);
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    public void StrikeEnemy()
    {
        health--;
        if(health <= 0)
        {
            DestroyEnemy();
        }
    }
}
