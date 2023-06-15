using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inworld.Packets;
using Inworld.Util;
using static Siccity.GLTFUtility.GLTFAccessor.Sparse;
using System;

namespace Inworld.Sample.UI
{
    public class GetCharacterDialogue : MonoBehaviour
    {
        public ChatPanel3D chatPanel3D;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void GetBubblesText()
        {
            String bubbles_text = "";
            var bubble_values = chatPanel3D.m_Bubbles.Values;
            foreach (ChatBubble bub in bubble_values)
            {
                bubbles_text += bub.Text;
            }
            Debug.Log(bubbles_text);
        }
    }
}