using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

    private float speed;
    private GameObject powerbar;
    private float power;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        powerbar = GameObject.Find("power(Clone)");
        power = powerbar.transform.localScale.z;
        rb = GetComponent<Rigidbody>();
        if (power < 0.2)
         {
            speed = 350;
        }
        else if (power > 0.2 && power < 0.3)
        {
            speed = 400;
        }
        else if (power > 0.3 && power < 0.4)
        {
            speed = 450;
        }
        else if (power > 0.4 && power < 0.5)
        {
            speed = 500;
        }
        else if (power > 0.5 && power < 0.6)
        {
            speed = 550;
        }
        else if (power > 0.6 && power < 0.7)
        {
            speed = 600;
        }
        else if (power > 0.7 && power < 0.8)
        {
            speed = 650;
        }
        else if (power > 0.8 && power < 0.9)
        {
            speed = 700;
        }
        else if (power > 0.9 && power < 1)
        {
            speed = 750;
        }
        else if (power > 1 && power < 1.1)
        {
            speed = 800;
        }
        else if (power > 1.1 && power < 1.2)
        {
            speed = 850;
        }
        else if (power > 1.2 && power < 1.3)
        {
            speed = 900;
        }
        else if (power > 1.3 && power < 1.4)
        {
            speed = 950;
        }
        else if (power > 1.4 && power < 1.5)
        {
            speed = 1000;
        }
        else if (power > 1.5 && power < 1.6)
        {
            speed = 1100;
        }
        else if (power > 1.6 && power < 1.7)
        {
            speed = 1200;
        }
        else if (power > 1.7 && power < 1.8)
        {
            speed = 1300;
        }
        else if (power > 1.8 && power < 1.9)
        {
            speed = 1400;
        }
        else if (power > 1.9 && power < 2)
        {
            speed = 1500;
        }
        else if (power > 2)
        {
            speed = 1600;
        }
        rb.AddForce(transform.forward * speed);
    }
	
	// Update is called once per frame
	void Update () {
    }
}
