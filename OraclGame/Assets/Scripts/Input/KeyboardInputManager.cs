using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputManager : InputManager
{
    //EVENTS
    public static event MoveInputHandler OnMoveInput;
    public static event RotateInputHandler OnRotateInput;
    public static event ZoomInputHandler OnZoomInput;
        
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) //Add that the mouse must be over the tray?
        {
            OnMoveInput?.Invoke(Vector3.forward); //Make this invoke a camera movement to the dice tray, creat new method?
        }

        //Add later triggers for citizen speech and book viewing
    }

}
