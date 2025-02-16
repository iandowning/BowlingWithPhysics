using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    private bool isBallLaunched = false;
    public float ballSpeed = 2f;
    private Rigidbody ballRB;


    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        inputManager.OnSpacePressed.AddListener(LaunchBall);
        ResetBall();

    }
    public void ResetBall(){
        isBallLaunched = false;
        ballRB.isKinematic = true;
        launchIndicator.gameObject.SetActive(true);
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
    }

    public void LaunchBall()
    {
        if (isBallLaunched) return;
    
        isBallLaunched = true;
        ballRB.isKinematic = false;
        ballRB.AddForce(launchIndicator.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
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