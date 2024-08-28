using UnityEngine;

public class OrdaMove : MonoBehaviour
{
    public float horizontalStep;
    public float verticalStep;
    public float timeStep;
    public float currentTimeStep;
    
    private int side; //1 = direita | -1 = esquerda

    void Start()
    {
        currentTimeStep = 0.0f;
        side = 1;
    }

    void Update()
    {
        HorizontalMove();
    }

    public void VerticalMove(int callSide)
    {
        if (callSide == 1 && side == 1)
        {
            SetSideLeft();
            transform.position += new Vector3(0, verticalStep, 0);
        }
        else if (callSide == -1 && side == -1)
        {
            SetSidRight();
            transform.position += new Vector3(0, verticalStep, 0);
        }
    }

    private void HorizontalMove()
    {
        currentTimeStep += Time.deltaTime;

        if(currentTimeStep >= timeStep)
        {
            currentTimeStep = 0;
            transform.position += new Vector3(horizontalStep*side, 0, 0);
        }
    }

    private void SetSideLeft()
    {
        side = -1;
    }

    private void SetSidRight()
    {
        side = 1;
    }
}
