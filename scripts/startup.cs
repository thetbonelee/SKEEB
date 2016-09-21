using UnityEngine;
using System.Collections;

public class startup : MonoBehaviour {

    public GameObject launcher;
	// Use this for initialization
	void Start () {
        Instantiate(launcher, new Vector3(0.011f, 0.393f, -10.721f), transform.rotation);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
