using UnityEngine;

public class EnemySensor : MonoBehaviour
{
    
    public float sideLimit;

    public OrdaMove ordaMove;
    void Start()
    {
        ordaMove = GameObject.Find("Orda").GetComponent<OrdaMove>();
    }

    void Update()
    {
        DetectSideLimit();
    }

    public void DetectSideLimit()
    {
        if(transform.position.x > sideLimit)
        {
            ordaMove.VerticalMove(1);
        }
        else if(transform.position.x < -sideLimit)
        {
            ordaMove.VerticalMove(-1);
        }
    }
}
