using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ShotManager shotManager;

    void Start()
    {
        shotManager = GetComponent<ShotManager>();
    }
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
