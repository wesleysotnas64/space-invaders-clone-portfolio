using UnityEngine;

public class EnemySensor : MonoBehaviour
{
    
    public float sideLimit;

    private OrdaMove ordaMove;
    void Start()
    {
        ordaMove = transform.parent.gameObject.GetComponent<OrdaMove>();
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
