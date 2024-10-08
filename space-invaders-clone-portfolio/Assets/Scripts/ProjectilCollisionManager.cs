using UnityEngine;

public class ProjectilCollisionManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        string tag = collision2D.gameObject.tag;
        GameObject obj = collision2D.gameObject;

        switch (tag)
        {
            case "Enemy":
                obj.GetComponent<Enemy>().StrikeEnemy();
                break;

            case "Barrier":
                obj.GetComponent<Barrier>().StrikeBarrier();
                break;
            default:

            case "Ufo":
                obj.GetComponent<Ufo>().StrikeEnemy();
                break;
        }

        Destroy(gameObject);
    }
}
