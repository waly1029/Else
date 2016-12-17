using UnityEngine;
using System.Collections;

public class TabView : MonoBehaviour {

	[SerializeField]
	public GameObject[] panel;

	[SerializeField]
	private TabViewModel tabviewModel;

	void Awake(){
		tabviewModel
		= GetComponent<TabViewModel> ();
	}

	public void TabSetActive(int setactiveNo){
		tabviewModel.SetTabState (setactiveNo);
		Debug.Log ("Set:" + setactiveNo);
	}
}
