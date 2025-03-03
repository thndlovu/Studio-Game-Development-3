using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private bool isGrounded;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        inputManager.OnMove.AddListener(MovePlayer);
        inputManager.OnSpacePressed.AddListener(Jump);
        rb = GetComponent<Rigidbody>();
    }

    private void MovePlayer(Vector3 direction){
        Vector3 moveDirection = new(direction.x, 0f, direction.z);
        rb.AddForce(speed * moveDirection);
    }

    private void Jump(){
        if(isGrounded) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; 
        }
    }

     private void OnCollisionEnter(Collision collision) {
        isGrounded = true;
    }
}
