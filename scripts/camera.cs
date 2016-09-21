using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject ball;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if(ball == null)
        {
            ball = GameObject.Find("Sphere(Clone)");
        }
        transform.position = ball.transform.position + offset;

    }
}
