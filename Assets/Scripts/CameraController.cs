﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

//	private Vector3 offset;

//	void start() {
//		offset = transform.position - player.transform.position;
//	}

	void LateUpdate() {
		transform.position = player.transform.position + new Vector3 (0, 10, -10);
	}
}
