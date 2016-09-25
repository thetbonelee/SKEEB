using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour
{
	private Vector3 left = new Vector3(0,0.5f,7);
	private Vector3 right = new Vector3(0,5,7);

	void Update() {
		transform.position = Vector3.Lerp (left, right, Mathf.PingPong(Time.time * 1.5f, 1.0f));
	}
}
