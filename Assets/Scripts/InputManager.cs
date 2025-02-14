using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }

        Vector2 inputVector = Vector2.zero;
        if(Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;
        }
        if(Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;
        }

        OnMove?.Invoke(inputVector);
    }
}
