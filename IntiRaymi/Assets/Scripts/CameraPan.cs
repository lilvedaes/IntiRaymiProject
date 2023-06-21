using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 startPosition; // This is where the camera will start
    Vector3 movedPosition = new Vector3(0, 1, 3); // This is where the camera will move when object is clicked
    Quaternion startRotation;
    Quaternion movedRotation = new Quaternion(0, 0.997564077f, 0.0697564706f, 0);

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator PanCameraToStand()
    {
        Debug.Log("Click");
        startPosition = transform.position;
        startRotation = transform.rotation;
        float lerpDuration = 3;
        float timeElapsed = 0;

        while (transform.position != movedPosition)
        {
            transform.position = Vector3.Lerp(startPosition, movedPosition, timeElapsed / lerpDuration);
            transform.rotation = Quaternion.Lerp(startRotation, movedRotation, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = movedPosition;
        transform.rotation = movedRotation;
    }

    public IEnumerator PanCameraAwayFromStand()
    {
        movedPosition = transform.position;
        movedRotation = transform.rotation;
        Debug.Log("Click");
        float lerpDuration = 3;
        float timeElapsed = 0;

        while (transform.position != startPosition)
        {
            transform.position = Vector3.Lerp(movedPosition, startPosition, timeElapsed / lerpDuration);
            transform.rotation = Quaternion.Lerp(movedRotation, startRotation, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}