using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	public float snap = 0;
	public float current = 0;
	public float delai = 10;

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

	void OnGUI () {
		Event e = Event.current;
		if (e.control == this && e.type == EventType.mouseDown) {
			snap = Time.realtimeSinceStartup;
			Time.timeScale = 1-Time.timeScale;
		}
	}

}
