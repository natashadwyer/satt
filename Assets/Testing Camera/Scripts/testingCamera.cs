using UnityEngine;
using System.Collections;

public class testingCamera : MonoBehaviour {

	public GameObject cameraVR;
	public GameObject GVRviewer;
	public GameObject OverlayCanvas;
	public Vector3 cameraPosition;

	// Use this for initialization
	void Start () {

		if (Application.isEditor) {
			print ("Editor Change Camera to Standard (Mouse Move)");
			if (!cameraVR) {
				print ("No VR camera - Searching...");
				cameraVR = GameObject.Find ("Main Camera");
				if (cameraVR) {
					print ("Found VR camera");
					cameraVR.SetActive (false);
				} else {
					print ("no VR camera found");
				};
			} else {
				print ("Found VR camera");
				cameraVR.SetActive (false);
			}
			;



			if (!GVRviewer) {
				print ("No GVRviewer - Searching...");
				GVRviewer = GameObject.Find ("GvrViewerMain");
				if (GVRviewer) {
					print ("Found GVRviewer");
					GVRviewer.SetActive (false);
				} else {
					print ("no GVRviewer found");
				}
				;
			} else {
				print ("Found GVRviewer");
				GVRviewer.SetActive (false);
			}
			;

			if (!OverlayCanvas) {
				print ("No Overlay Canvas - Searching...");
				OverlayCanvas = GameObject.Find ("Overlay Canvas");
				if (OverlayCanvas) {
					print ("Found OverlayCanvas");
					OverlayCanvas.SetActive (false);
				} else {
					print ("no Overlay Canvas found");
				}
				;
			} else {
				print ("Found Overlay Canvas");
				OverlayCanvas.SetActive (false);
			};

		} else {
			gameObject.SetActive (false);
		};
	}
	
	// Update is called once per frame
	void Update () {
		cameraPosition = cameraVR.transform.position;
		transform.position = cameraPosition;
	}
}
