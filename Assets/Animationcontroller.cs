using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Animationcontroller : MonoBehaviour,ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;

	private bool mShowGUIButton = false;
	private Rect mButtonRect = new Rect(50,50,200,200);
	private Rect mButtonRect2 = new Rect (50, 300, 200, 200);
	private Rect mButtonRect3 = new Rect (50, 550, 200, 200);
	private Rect mButtonRect4 = new Rect (50, 800, 200, 200);
	public string youtubelink;
	public string googlelink;
	public Texture2D google;
	public Texture2D youtube;
	public Texture2D skype;
	public Texture2D service;

	public GameObject model_1;
	public GameObject model_2;

	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
		model_1.SetActive (false);
		model_2.SetActive (false);
		
	}
	
	// Update is called once per frame
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUIButton = true;
		}
		else
		{
			mShowGUIButton = false;
		}
	}

	void OnGUI() {
		if (mShowGUIButton) {
			Debug.Log ("button is on");
			GUIStyle style=new GUIStyle();
			if(GUI.Button(mButtonRect,google)){
				Application.OpenURL (googlelink);

			}
			if(GUI.Button(mButtonRect2,youtube)){
				Application.OpenURL (youtubelink);

			}
			if(GUI.Button(mButtonRect3,skype)){
				model_1.SetActive (true);
				model_2.SetActive (false);

			}
			if(GUI.Button(mButtonRect4,service)){
				
				model_2.SetActive (true);
				model_1.SetActive (false);
			}
		}
	}
}
