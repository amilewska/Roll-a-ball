using UnityEngine;

public class BoardController : MonoBehaviour
{
    /*
        class BoardController is create to:
        - moves the board
        - get the speed from the main menu (via GameManager)
    */

    [Header("Movement values")]
    float verticalInput;
    float horizontalInput;
    [SerializeField] float speed;

    
    void FixedUpdate()
    {
        if(GameManager.instance!= null) speed = GameManager.instance.boardSpeed;
        MoveBoard();

    }

    void MoveBoard()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.right, verticalInput * speed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.back, horizontalInput * speed * Time.fixedDeltaTime);
    }
}
