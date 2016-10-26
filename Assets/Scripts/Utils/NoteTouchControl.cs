using UnityEngine;
using System.Collections;

namespace NipponNoto.Utils
{
    public class NoteTouchControl : MonoBehaviour
    {
        public enum DragDirection
        {
            NONE,
            UP,
            UPSHORT,
            UPLONG,
            DOWN,
            RIGHT,
            LEFT,
            UPRIGHT,
            UPLEFT,
            DOWNRIGHT,
            DOWNLEFT
        };

        private bool holdClick = false;
        private bool singleClick = false;

        public Vector2 mousePos;
        public Vector2 newMousePos;

        public DragDirection dragDir;

        public float dragVelocity = .0f;
        public float zoomFactor;

        void Start()
        {
            dragDir = DragDirection.NONE;
        }

        protected void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                singleClick = true;

                mousePos = Input.mousePosition;
            }

            if (Input.GetMouseButton(0))
            {
                holdClick = true;

                newMousePos = Input.mousePosition;
            }
            else
                dragDir = DragDirection.NONE;

            zoomFactor = Input.GetAxis("Mouse ScrollWheel");

            CheckDirection();
        }

        void CheckDirection()
        {
            if (newMousePos.x > (mousePos.x + 1.0f) || newMousePos.x < (mousePos.x + 20.0f)) 
            {
                if (newMousePos.y < mousePos.y)
                    dragDir = DragDirection.DOWN;
                else if (newMousePos.y > (mousePos.y+1.0f) || (newMousePos.y < (mousePos.y + 5.0f)))
                {
                    dragDir = DragDirection.UPSHORT;

                    dragVelocity = 5.0f;
                }
            }

            if (newMousePos.x > (mousePos.x + 40.0f))
            {
                if (newMousePos.y < mousePos.y)
                    dragDir = DragDirection.DOWNRIGHT;
                else
                    dragDir = DragDirection.UPRIGHT;
            }

            if (newMousePos.x == mousePos.x && newMousePos.y == mousePos.y)
            {
                dragDir = DragDirection.NONE;

                dragVelocity = .0f;
            }
                
        }
    }
}


