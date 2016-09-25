using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject ball;

    private Vector3 offset;
	private float followDist = -3.5f;
	private float maxZoom = -2.5f;
	private Vector3 defaultCamera = new Vector3(0, 6, -15);
	private float delay = 2;
	private bool zoom = false;
	// Use this for initialization
	void Start () {
        offset = transform.position - ball.transform.position;
	}

	// Update is called once per frame
	void Update () {

    }

	void LateUpdate ()
	{

		ball = GameObject.Find("Sphere(Clone)");
		if (ball) {
			if (transform.position.z < maxZoom) {
				transform.position = ball.transform.position + offset;
				Vector3 tempPosition = new Vector3 (defaultCamera.x, defaultCamera.y, transform.position.z + followDist);
				transform.position = tempPosition;
				zoom = true;
			}
		}
		else if(delay > 0 && zoom){
			delay -= Time.deltaTime;
		}
		else {
			transform.position = defaultCamera;
			delay = 2;
			zoom = false;
		}
	}
}
