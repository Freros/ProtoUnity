using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MouseOnUnit : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {

	public GameObject dragLineProto;
	GameObject moveLine = null;
	public float cross;
	public float angle;

	public void OnBeginDrag (PointerEventData eventData){
		//		Debug.Log ("MouseOnUnit.OnBeginDrag");
		if (moveLine == null) {
			moveLine = (GameObject) Instantiate (dragLineProto, transform.position, transform.rotation);
			moveLine.transform.SetParent(transform);
		}
		moveLine.transform.position = transform.position;
		moveLine.GetComponent<RectTransform> ().sizeDelta=new Vector2(moveLine.GetComponent<RectTransform> ().rect.width,100);
	}
	
	public void OnDrag (PointerEventData eventData){
//		Debug.Log ("MouseOnUnit.OnDrag");
		angle=Vector2.Angle (new Vector2 (0, 1),  new Vector2 (eventData.position.x-transform.position.x,eventData.position.y-transform.position.y));
		cross = Mathf.Sign(Vector3.Cross (new Vector2 (0, 1), new Vector2 (eventData.position.x - transform.position.x, eventData.position.y - transform.position.y)).z);
		moveLine.GetComponent<RectTransform> ().sizeDelta=new Vector2(moveLine.GetComponent<RectTransform> ().rect.width,Vector2.Distance(new Vector2(eventData.position.x,eventData.position.y),new Vector2(transform.position.x,transform.position.y)));
		moveLine.GetComponent<RectTransform> ().localEulerAngles= new Vector3(0,0,angle*cross);
	}
	
	public void OnEndDrag (PointerEventData eventData){
//		Debug.Log ("MouseOnUnit.OnEndDrag");
		this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 ((eventData.position.x - transform.position.x)*7, (eventData.position.y - transform.position.y)*7),ForceMode2D.Impulse);
//		this.GetComponent<Rigidbody2D> ().Sleep ();
	}

}
