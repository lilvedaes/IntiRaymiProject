using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Inworld.Sample
{
    public class SetSelectedCharacter : MonoBehaviour
    {
        [SerializeField] GameObject textField;
        [SerializeField] CameraPan cameraPan;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                InworldController.Instance.m_CurrentCharacter = GetComponent<InworldCharacter>();
                other.GetComponent<InworldPlayer>().ToggleCanvas();
                other.GetComponent<InworldCameraController>().enabled = false;
                EventSystem.current.SetSelectedGameObject(textField);

                // Camera zooms in
                StartCoroutine(cameraPan.PanCameraToStand());
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                InworldController.Instance.m_CurrentCharacter = null;

                // Camera returns to original position
                StartCoroutine(cameraPan.PanCameraAwayFromStand());
            }
        }
    }
}
