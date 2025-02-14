using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    private bool isBallLaunched = false;
    public float ballSpeed = 2f;
    private Rigidbody ballRB;


    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();

        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    public void LaunchBall()
    {
        if (isBallLaunched) return;
    
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    // Update is called once per frame
   /*  void Update()
    { */
/*         Vector3 inputVector3 = Vector3.zero;
        Vector2 inputVector = Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        
        if(Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if(Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }

        if(Input.GetKey(KeyCode.Space)&&(isInContact))
        {
            inputVector3 += new Vector3(0, 0, 5);
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, inputVector3.z, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane);

    
        Debug.Log("Resultant Vector: " + inputVector*ballSpeed);
 */
    
}