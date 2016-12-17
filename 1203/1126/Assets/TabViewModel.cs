using UnityEngine;
using System.Collections;

public class TabViewModel : MonoBehaviour {

	//const string FIND_TABVIEW_OBJECT_NAME = "TabView";

	[SerializeField]
	TabView tabView;

	void Awake(){
		//GameObject tabView = GameObject.Find (FIND_TABVIEW_OBJECT_NAME);
		//if(tabView == null)Resources.Load(string path)
		tabView = tabView.GetComponent<TabView> ();
	}

	void Update(){
		TabViewChanger ();
	}

	public void SetTabState(int tabNo)
	{
		switch (tabNo) {
		case 0:
			UIModel.activeTab = UIModel.TabState.Tab1;
			Debug.Log ("Set Tab1");
			break;
		case 1:
			UIModel.activeTab = UIModel.TabState.Tab2;
			Debug.Log ("Set Tab2");
			break;
		case 2:
			UIModel.activeTab = UIModel.TabState.Tab3;
			Debug.Log ("Set Tab3");
			break;
		case 3:
			UIModel.activeTab = UIModel.TabState.Tab4;
			Debug.Log ("Set Tab4");
			break;

		default:
			break;
		}
	}

	void TabViewChanger(){
		switch (UIModel.activeTab) {
		case UIModel.TabState.Tab1:
			tabView.panel [0].SetActive (true);
			tabView.panel [1].SetActive (false);
			tabView.panel [2].SetActive (false);
			tabView.panel [3].SetActive (false);
			break;

		case UIModel.TabState.Tab2:
			tabView.panel [0].SetActive (false);
			tabView.panel [1].SetActive (true);
			tabView.panel [2].SetActive (false);
			tabView.panel [3].SetActive (false);
			break;

		case UIModel.TabState.Tab3:	
			tabView.panel [0].SetActive (false);
			tabView.panel [1].SetActive (false);
			tabView.panel [2].SetActive (true);
			tabView.panel [3].SetActive (false);
			break;

		case UIModel.TabState.Tab4:
			tabView.panel [0].SetActive (false);
			tabView.panel [1].SetActive (false);
			tabView.panel [2].SetActive (false);
			tabView.panel [3].SetActive (true);
			break;

		default:
			break;
		}
	}

}
