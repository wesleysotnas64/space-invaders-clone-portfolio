using UnityEngine;

public class ShotManager : MonoBehaviour
{
    public GameObject projectilGameObject;
    public Transform cannonTransform;

    public void Shot(Vector2 direction)
    {
        GameObject projectil = Instantiate(projectilGameObject);
        projectil.transform.position = cannonTransform.position;
        projectil.transform.up = direction;
    }
}
