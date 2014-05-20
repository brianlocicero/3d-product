using UnityEngine;
using System.Collections;

public class AppController : MonoBehaviour {

	public GameObject targetItem;
	public Camera GUICamera;
	public int rotationRate = 1;
	public RaycastHit hit;
	
	private bool wasRotating = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {

		if (Input.touchCount > 0)  {   //  If there are touches...
			
			Touch theTouch = Input.GetTouch(0);       //    Cache Touch (0)
			Ray ray = Camera.main.ScreenPointToRay(theTouch.position);

			//if( Physics.Raycast(ray,out hit,50) ) { optional restrict to object itself
				if(Input.touchCount == 1)
				{
					if (theTouch.phase == TouchPhase.Began) 
					{
						wasRotating = false; 
					}     
					
					if (theTouch.phase == TouchPhase.Moved) 
					{
						targetItem.transform.Rotate(theTouch.deltaPosition.y * rotationRate, -(theTouch.deltaPosition.x * rotationRate), 0, Space.World);
						wasRotating = true;
					}     
				}	
			//}
		}
	}
}
