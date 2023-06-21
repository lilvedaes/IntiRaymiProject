using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetModelDirection : MonoBehaviour
{
    private Vector3 positionLastFrame;
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        positionLastFrame = transform.position;
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedVector = transform.position - positionLastFrame;
        positionLastFrame = transform.position;

        if (movedVector.magnitude > 0.001f)
        {
            transform.forward = movedVector;
            m_Animator.Play("Base Layer.Walking");
        }
        else
        {
            m_Animator.Play("Base Layer.Idle");
        }
    }
}
