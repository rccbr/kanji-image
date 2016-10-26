using UnityEngine;
using System.Collections;

namespace NipponNoto.Events
{
    public class MoveTouchEvents : MonoBehaviour
    {
        public delegate void TouchEvent(float move);
        public static event TouchEvent OnMoveTouch;

        public static bool hasFinishedTouchEvent = false;


        void Start()
        {

        }

        public static void PerformScreenDrag(float drag)
        {
            if (OnMoveTouch != null && hasFinishedTouchEvent)
            {
                OnMoveTouch(drag);

                hasFinishedTouchEvent = false;
            }
        }
    }
}


