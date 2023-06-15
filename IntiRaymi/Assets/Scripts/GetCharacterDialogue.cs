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
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void GetCharacterLine(string input, string output)
        {
            if (input != "Player")
            {
                Debug.Log(output);
            }
        }
    }
}