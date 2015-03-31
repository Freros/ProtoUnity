using UnityEngine;
using System.Collections;

public class OnRingClick : MonoBehaviour {

	public GameObject shootTargetProto;
	public GameObject shootTarget = null;
	public int count = -1;
	public bool clicked = false;
	public Event view;
	// Use this for initialization
	void Start () {
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate () {
	}

	void OnMouseDown() {
		clicked = true;
		count = Event.current.clickCount;
		if (Event.current.clickCount > 1) {
			if (shootTarget == null) {
				shootTarget = (GameObject)Instantiate (shootTargetProto, transform.position, transform.rotation);
			}
			shootTarget.transform.position = new Vector3 (transform.position.x, transform.position.y, -1);
		}
	}
	
}
