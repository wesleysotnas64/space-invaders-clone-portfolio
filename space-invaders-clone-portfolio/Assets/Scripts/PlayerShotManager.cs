using UnityEngine;

public class PlayerShotManager : MonoBehaviour
{
    public GameObject projectilGameObject;
    public Transform playerCannonTransform;

    public void Shot()
    {
        GameObject projectil = Instantiate(projectilGameObject);
        projectil.transform.position = playerCannonTransform.position;
        projectil.transform.up = Vector2.up;
    }
}
