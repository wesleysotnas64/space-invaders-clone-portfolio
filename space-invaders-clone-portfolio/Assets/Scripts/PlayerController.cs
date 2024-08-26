using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMove playerMove;

    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A)) playerMove.LeftMove();
        if(Input.GetKey(KeyCode.D)) playerMove.RightMove();
    }
}
