using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {
	[SerializeField]
	private float speed = 1;
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Horizontal") * -speed;
		move *= Time.deltaTime;
		transform.position = new Vector3(transform.position.x + move, transform.position.y, transform.position.z);
	}
}
