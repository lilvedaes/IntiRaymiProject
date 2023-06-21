using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetModelDirection : MonoBehaviour
{
    private Vector3 positionLastFrame;
    // Start is called before the first frame update
    void Start()
    {
        positionLastFrame = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = transform.position - positionLastFrame;
        positionLastFrame = transform.position;
    }
}
