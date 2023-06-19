using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 startPosition; // This is where the camera will start
    Vector3 movedPosition = new Vector3(0.0399999991f, 1.60699999f, 4.82999992f); // This is where the camera will move when object is clicked
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
        PanCameraToStand();
    }

    public void PanCameraToStand()
    {
        Debug.Log("Click");
        transform.position = Vector3.MoveTowards(transform.position, movedPosition, 3.5f * Time.deltaTime);
    }
}