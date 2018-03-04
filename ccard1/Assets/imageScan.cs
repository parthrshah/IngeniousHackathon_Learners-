using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class imageScan : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	// Use this for initialization
	void Start () {
		//SceneManager.LoadScene("UIController_Popups", LoadSceneMode.Single);
		vbButtonObject = GameObject.Find("VirtualButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("button down");
		SceneManager.LoadScene("UIController_Popups", LoadSceneMode.Single);

	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){


	}
	/*void OnGUI()
	{
		//This displays a Button on the screen at position (20,30), width 150 and height 50. The button’s text reads the last parameter. Press this for the SceneManager to load the Scene.
		if (GUI.Button(new Rect(20, 30, 150, 30), "Other Scene Single"))
		{
			//The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
			SceneManager.LoadScene("UIController_Popups", LoadSceneMode.Single);
		}*/
			


}
