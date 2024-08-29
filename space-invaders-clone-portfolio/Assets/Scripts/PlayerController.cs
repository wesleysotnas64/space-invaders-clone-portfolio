using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMove playerMove;
    public ShotManager shotManager;

    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        shotManager = GetComponent<ShotManager>();
    }

    void Update()
    {
        //Movimentação
        if(Input.GetKey(KeyCode.A)) playerMove.LeftMove();
        if(Input.GetKey(KeyCode.D)) playerMove.RightMove();
        
        //Shot
        if(Input.GetKeyDown(KeyCode.Space)) shotManager.Shot(Vector2.up);
    }
}
