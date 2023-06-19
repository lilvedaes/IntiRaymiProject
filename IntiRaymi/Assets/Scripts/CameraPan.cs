using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 startPosition; // This is where the camera will start
    Vector3 movedPosition = new Vector3(10, 0, -10); // This is where the camera will move when object is clicked
    bool cameraMoved = false; // this checks to see if the camera was moved
    [SerializeField] private LayerMask objectLayer;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        //startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PanCameraToStand()
    {
        Debug.Log("Click");
        //Create variables to cast a ray on Cube 1
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Detect if ray hit Cube 1
        if (Physics.Raycast(ray, out hit, 100, objectLayer))
        {

            //If camera was not moved...
            if (!cameraMoved)
            {
                // Move the camera into position
                transform.position = movedPosition;
                cameraMoved = true;
            }

            //If camera was moved...
            else
            {
                // Move the camera back into the starting position
                transform.position = startPosition;
                cameraMoved = false;
            }
        }
    }
}