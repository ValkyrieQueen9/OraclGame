using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom1 : MonoBehaviour
{
    public Transform camObject; 
    public GameObject CamViewTarget;
    public float moveSpeed;

    //if left mouse click is used on dice trigger gameobject, move camera view to position

    public void DiceZoom()
    {
        Vector3.MoveTowards(transform.position, CamViewTarget.transform.position, moveSpeed);
        Debug.Log("DiceZoomClicked");
    }
    
}
