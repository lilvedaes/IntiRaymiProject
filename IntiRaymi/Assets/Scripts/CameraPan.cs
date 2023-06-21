using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 startPosition; // This is where the camera will start
    Vector3 movedPosition = new Vector3(0, 0, 0); // This is where the camera will move when object is clicked
    Quaternion startRotation;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator PanCameraToStand(Quaternion movedRotation)
    {
        float lerpDuration = 1.5f;
        float timeElapsed = 0;

        while (timeElapsed < lerpDuration)
        {
            transform.localPosition = Vector3.Lerp(startPosition, movedPosition, timeElapsed / lerpDuration);
            transform.localRotation = Quaternion.Lerp(startRotation, movedRotation, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = movedPosition;
        transform.localRotation = movedRotation;
        yield return null;
    }

    public IEnumerator PanCameraAwayFromStand()
    {
        float lerpDuration = 1.5f;
        float timeElapsed = 0;

        while (timeElapsed < lerpDuration)
        {
            transform.localPosition = Vector3.Lerp(movedPosition, startPosition, timeElapsed / lerpDuration);
            transform.localRotation = Quaternion.Lerp(transform.rotation, startRotation, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = startPosition;
        transform.rotation = startRotation;
        yield return null;
    }
}