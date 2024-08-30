using System.Collections.Generic;
using UnityEngine;

public class Orda : MonoBehaviour
{
    public List<GameObject> enemies;

    void Start()
    {
    }

    void Update()
    {
        VerifyDestroyOrda();
    }

    private void VerifyDestroyOrda()
    {
        if(enemies.Count <= 0)
        {
            Destroy(gameObject);
        }
    }
}
