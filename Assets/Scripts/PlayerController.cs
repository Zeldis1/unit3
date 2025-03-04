using UnityEngine;
public class PlayerController : MonoBehaviour
   
{
    
    // variables
    private Rigidbody playerRB;
    public float jumpForce = 15;
    public float gravityModifer;
    public bool isOnGround = true;
    public bool gameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
       Physics.gravity *= gravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isOnGround = true;
        else if (collision.gameObject.CompareTag("Obstacle"))
                gameOver = true;
        Debug.Log("Game Over!");
    }

}