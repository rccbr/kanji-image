using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NipponNoto.Utils
{
    public class NotePinch : MonoBehaviour
    {
        public int screenTouch = 0;

        public Text textScreen;

        void Start()
        {

        }

        void Update()
        {
            if (Input.touchCount == 2)
            {
                screenTouch = 2;

                textScreen.text = screenTouch.ToString();

                Debug.Log("Multiple touch count");
            }
        }
    }
}


