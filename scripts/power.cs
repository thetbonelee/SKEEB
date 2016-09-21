using UnityEngine;
using System.Collections;

public class power : MonoBehaviour {

    public GameObject emitter;
    public GameObject ball;
    public float max;
    public float min;
    private float size = 0.05f;
    private bool grow = true;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (grow)
        {
            if (transform.localScale.z > max)
            {
                size = -Mathf.Abs(size);
            }
            if (transform.localScale.z < min)
            {
                size = Mathf.Abs(size);
            }
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + size);

            if (Input.GetKeyDown("space"))
            {
                grow = false;
                emitter = GameObject.FindGameObjectWithTag("Spawn");
                GameObject tempBall;
                tempBall = Instantiate(ball, emitter.transform.position, emitter.transform.rotation) as GameObject;
            }
        }
        }
}
