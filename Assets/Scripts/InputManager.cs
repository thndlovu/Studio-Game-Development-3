using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour {
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDpown)
    }
}
