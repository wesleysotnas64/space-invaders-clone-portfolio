using UnityEngine;

public class ShotManager : MonoBehaviour
{
    public GameObject projectilGameObject;
    public Transform cannonTransform;

    public void Shot()
    {
        GameObject projectil = Instantiate(projectilGameObject);
        projectil.transform.position = cannonTransform.position;
        projectil.transform.up = Vector2.up;
    }
}
