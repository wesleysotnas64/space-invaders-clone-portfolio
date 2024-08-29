using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ShotManager shotManager;

    void Start()
    {
        shotManager = GetComponent<ShotManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) shotManager.Shot(Vector2.down);
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
