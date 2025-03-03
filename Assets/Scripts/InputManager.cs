using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour {
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            OnSpacePressed?.Invoke();
        }

        Vector3 input = Vector3.zero;
        if(Input.GetKey(KeyCode.A)){
            input += Vector3.left;
        }
        if(Input.GetKey(KeyCode.D)){
            input += Vector3.right;
        }
        if(Input.GetKey(KeyCode.S)){
            input += Vector3.back;
        }
        if(Input.GetKey(KeyCode.W)){
            input += Vector3.forward;
        }
        OnMove?.Invoke(input);
    }
}
