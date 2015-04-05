using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour,IPointerDownHandler {

	public float snap = 0;
	public float current = 0;
	public float delai = 10;
	public bool ordering = true;

	// Update is called once per frame
	void Start(){
		Time.timeScale = 0;
	}

	void Update () {
		current = Time.realtimeSinceStartup;
		if (Time.realtimeSinceStartup > snap + delai) {
			Time.timeScale = 1-Time.timeScale;
		}
	}

	public void OnPointerDown (PointerEventData eventData) {
		snap = Time.realtimeSinceStartup;
		Time.timeScale = 1-Time.timeScale;
	}

}
