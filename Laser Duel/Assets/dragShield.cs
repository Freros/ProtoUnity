using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class dragShield : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {

	public bool dragging = false;
	public bool colliding = false;
	public GameObject target;
	public int childCount = 0;
	public float childX = 0;
	public float childY = 0;
	public float childZ = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnBeginDrag (PointerEventData eventData){
	}

	public void OnDrag (PointerEventData eventData){
		Debug.Log ("OnDrag");
	}

	public void OnEndDrag (PointerEventData eventData){
	}
	/*
	void FixedUpdate () {
		if (dragging) {
			transform.position = new Vector3 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y, -1);
		}
	}
	
	void OnMouseDown() {
		dragging = true;
	}
	
	void OnMouseUp() {
		dragging = false;
		if (target != null) {
			transform.position = new Vector3 (target.transform.position.x, target.transform.position.y, -1);
		} else {
			transform.position = transform.GetChild(0).transform.localPosition;
		}
	}

	void OnTriggerEnter2D (Collider2D collision) {
//		nameCol = collision.gameObject.;
		colliding = true;
		if (collision.gameObject.name == "Player 1") {
			target = collision.gameObject;
		}
	}

	void OnTriggerExit2D (Collider2D collision) {
		//		nameCol = collision.gameObject.;
		colliding = false;
		target = null;
	}
	*/
}
