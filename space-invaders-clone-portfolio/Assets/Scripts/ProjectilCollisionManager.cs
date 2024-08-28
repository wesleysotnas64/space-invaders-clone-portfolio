using UnityEngine;

public class ProjectilCollisionManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;

        switch (tag)
        {
            case "Enemy":
                collision2D.gameObject.GetComponent<Enemy>().DestroyEnemy();
                break;
            default:
                break;
        }

        Destroy(gameObject);
    }
}
