using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMove playerMove;
    public PlayerShotManager playerShotManager;

    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        playerShotManager = GetComponent<PlayerShotManager>();
    }

    void Update()
    {
        //Movimentação
        if(Input.GetKey(KeyCode.A)) playerMove.LeftMove();
        if(Input.GetKey(KeyCode.D)) playerMove.RightMove();
        
        //Shot
        if(Input.GetKeyDown(KeyCode.Space)) playerShotManager.Shot();
    }
}
