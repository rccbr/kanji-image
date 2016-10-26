using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using NipponNoto.Utils;
using NipponNoto.Events;
using System.Collections;

namespace NipponNoto.Control
{
    public class NoteScroll : NoteTouchControl
    {
        public const float PAGETOPLIMIT = -132.0f;
        public const float PAGEDOWNLIMIT = 168.0f;
        public const float PAGERIGHTLIMIT = -116.0f;
        public const float PAGELEFTLIMIT = 52.0f;

        public float pageScreenPosToGo = 0.0f;

        public RectTransform noteRectTransform;
        public CanvasScaler canvasScaler;

        void Awake()
        {
            noteRectTransform = GetComponent<RectTransform>();

            canvasScaler = transform.parent.GetComponent<CanvasScaler>();

            DOTween.Init();
        }

        void Start()
        {
            MoveTouchEvents.OnMoveTouch += DragScreen;

            //noteRectTransform.transform.DOMoveY(-20, 1).From(true);
        }

        new void Update()
        {
            base.Update();

            /*if (dragDir == DragDirection.UPSHORT)
            {
                noteRectTransform.transform.DOMoveY(-10, 1).From(false);

                //dragDir = DragDirection.NONE;
            }*/
                

              if (dragDir == DragDirection.UP)
              {
                  noteRectTransform.localPosition = Vector3.Lerp(noteRectTransform.localPosition,  new Vector3(noteRectTransform.localPosition.x, PAGETOPLIMIT,
                      noteRectTransform.localPosition.z), Time.deltaTime * 5.0f);
              }

              if (dragDir == DragDirection.UPSHORT)
              {
                  pageScreenPosToGo = noteRectTransform.localPosition.y - 10.0f;

                  StartCoroutine(ExecuteDrag(new Vector3(noteRectTransform.localPosition.x, pageScreenPosToGo, noteRectTransform.localPosition.z)));
              }

              if (dragDir == DragDirection.UPRIGHT)
              {
                  noteRectTransform.localPosition = Vector3.Lerp(noteRectTransform.localPosition, new Vector3(PAGERIGHTLIMIT, PAGETOPLIMIT,
                      noteRectTransform.localPosition.z), Time.deltaTime * 5.0f);
              }

              if (dragDir == DragDirection.DOWN)
              {
                  noteRectTransform.localPosition = Vector3.Lerp(noteRectTransform.localPosition, new Vector3(noteRectTransform.localPosition.x, PAGEDOWNLIMIT,
                      noteRectTransform.localPosition.z), Time.deltaTime * 5.0f);
              }

            ZoomInZoomOut();
        }

        void DragScreen(float posToGo)
        {
            noteRectTransform.localPosition = Vector3.Lerp(noteRectTransform.localPosition, new Vector3(noteRectTransform.localPosition.x, posToGo,
                   noteRectTransform.localPosition.z), Time.deltaTime * 5.0f);
        }

        void ZoomInZoomOut()
        {
            canvasScaler.matchWidthOrHeight += zoomFactor;
        }

        IEnumerator ExecuteDrag(Vector3 dest)
        {
            noteRectTransform.localPosition = Vector3.Lerp(noteRectTransform.localPosition, dest, Time.deltaTime * 5.0f);

            yield return null;

            //dragDir = DragDirection.NONE;
        }
    }
}


