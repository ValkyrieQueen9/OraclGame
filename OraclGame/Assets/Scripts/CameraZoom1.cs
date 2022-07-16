using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom1 : MonoBehaviour
{
    public Transform camObject; 
    public GameObject diceViewTarget;
    public float moveSpeed;

    //if left mouse click is used on dice trigger gameobject, move camera view to position
    private void Update()
    {
        /*if (Input.GetKey(KeyCode.Mouse0)) //Add that the mouse must be over the tray?
        {
            print ("Left mouse pressed");
           //Make this invoke a camera movement to the dice tray, creat new method?
        }
        */
    }

    public void DiceZoom()
    {
        print("DiceZoomActive");
        Vector3.MoveTowards(transform.position, diceViewTarget.transform.position, moveSpeed);
    }
    
}
