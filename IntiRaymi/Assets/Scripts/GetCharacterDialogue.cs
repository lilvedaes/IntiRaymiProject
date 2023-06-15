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

        public string[] keywords;
        public GameObject[] spawnObjects;
        // Start is called before the first frame update
        void Start()
        {
            foreach (GameObject obj in spawnObjects)
            {
                obj.SetActive(false);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void GetCharacterLine(string input, string output)
        {
            if (input != "Player")
            {
                int i = 0;
                foreach (string word in keywords)
                {
                    if (output.Contains(word) && !spawnObjects[i].activeSelf)
                        spawnObjects[i].SetActive(true);
                    i++;
                }
            }
        }
    }
}