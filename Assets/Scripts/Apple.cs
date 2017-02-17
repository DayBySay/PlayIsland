using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public enum STYLE {
		RED,
		BLUE,
		GOLDEN,
	}

	[SerializeField]
	private int point;
	[SerializeField]
	private STYLE style;

	public delegate void DoActionDelegate();
	public DoActionDelegate doAction;

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("hoge");
		if (doAction == null) {
			return;
		}

		doAction ();
	}
}