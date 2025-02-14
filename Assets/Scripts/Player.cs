using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;

    private Rigidbody rb;

    void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();
    }

    private void MovePlayer(Vector2 direction)
    {
        Vector3 movement = new Vector3(direction.x, 0f, direction.y);
        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
