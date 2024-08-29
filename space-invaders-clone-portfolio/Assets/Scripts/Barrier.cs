using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int resistance;

    public void StrikeBarrier()
    {
        resistance--;

        if(resistance <= 0)
        {
            Destroy(gameObject);
        }
    }
}
