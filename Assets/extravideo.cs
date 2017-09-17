using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class extravideo : MonoBehaviour,ITrackableEventHandler {

	// Use this for initialization
	private TrackableBehaviour mTrackableBehaviour;

	private bool mShowGUIButton = false;
	private Rect mButtonRect = new Rect(50,50,200,200);
	private Rect mButtonRect2 = new Rect (50, 300, 200, 200);
	private Rect mButtonRect3 = new Rect (50, 550, 200, 200);
	private Rect mButtonRect4 = new Rect (50, 800, 200, 200);
	public string youtubelink;
	public string googlelink;
	public string skypelink;
	public string Mlink;
	public Texture2D google;
	public Texture2D youtube;
	public Texture2D skype;
	public Texture2D Cargill;

	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}

	}

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
				Application.OpenURL (skypelink);

			}
			if(GUI.Button(mButtonRect4,Cargill)){
				Application.OpenURL (Mlink);

			}
		}
	}
}