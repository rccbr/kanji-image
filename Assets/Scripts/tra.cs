using UnityEngine;
using System.Collections;

public class tra : MonoBehaviour {

    public float dragVelocity = 5f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        dragVelocity *= 0.5f;

       transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x * dragVelocity, transform.position.y), Time.deltaTime * 1.0f);
	}
}
