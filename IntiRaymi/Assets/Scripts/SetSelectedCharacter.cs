using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inworld.Packets;
using Inworld.Util;

namespace Inworld
{
    public class SetSelectedCharacter : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
                InworldController.Instance.m_CurrentCharacter = GetComponent<InworldCharacter>();
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                InworldController.Instance.m_CurrentCharacter = null;
        }
    }
}
