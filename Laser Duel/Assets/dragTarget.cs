using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class dragTarget : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {


/*	void FixedUpdate () {
		if (dragging) {
			transform.position = new Vector3 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y, -1);
		}
	}

	*/

	public void OnBeginDrag (PointerEventData eventData){
		Debug.Log ("dragTarget.OnBeginDrag");
	}
	
	public void OnDrag (PointerEventData eventData){
		Debug.Log ("dragTarget.OnDrag");
		transform.position = eventData.position;
	}
	
	public void OnEndDrag (PointerEventData eventData){
		Debug.Log ("dragTarget.OnEndDrag");
	}

}
