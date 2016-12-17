using UnityEngine;
using System.Collections;

public static class UIModel{

	public enum TabState{
		Tab1,
		Tab2,
		Tab3,
		Tab4
	}

	public static TabState activeTab = TabState.Tab1;

}
