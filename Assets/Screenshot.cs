using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Application.CaptureScreenshot("Note.png", 17);

            Debug.Log("Screenshot taken");
        }
           
	}
}
