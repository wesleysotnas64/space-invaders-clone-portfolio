using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public EnemyType type;

    public float shotTime;
    public float currentShotTime;

    private ShotManager shotManager;

    [Range(0, 100)]
    public int shotChance;

    void Start()
    {
        shotManager = GetComponent<ShotManager>();
        currentShotTime = 0;
    }

    void Update()
    {
        ShotVerify();
    }

    public void ShotVerify()
    {
        currentShotTime += Time.deltaTime;
        if(currentShotTime >= shotTime)
        {
            currentShotTime = 0;

            if(Random.Range(0, 100) < shotChance)
            {
                Shot();
            }
        }
    }

    public void Shot()
    {
        shotManager.Shot(Vector2.down);
    }

    private void DestroyEnemy()
    {
        GameObject ordaPai = transform.parent.gameObject;
        ordaPai.GetComponent<Orda>().enemies.Remove(gameObject);
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
