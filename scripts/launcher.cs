using UnityEngine;
using System.Collections;

public class launcher : MonoBehaviour {

    public GameObject emitter;
    public GameObject powerMeter;
    public GameObject powerSpawn;
    public float speed;
    public float _Angle;
    public float _Period;
    private float _Time;
    private bool pivot = true;


    // Use this for initialization
    void Start () {
    }

 
	// Update is called once per frame
	void Update () {
        if (pivot)
        {
            _Time = _Time + Time.deltaTime;
            float phase = Mathf.Sin(_Time / _Period);
            transform.localRotation = Quaternion.Euler(new Vector3(0, phase * _Angle, 0));

            if (Input.GetKeyDown("space"))
            {
                pivot = false;
                GameObject powerArrow;
                powerArrow = Instantiate(powerMeter, powerSpawn.transform.position, powerSpawn.transform.rotation) as GameObject;
            }
        }
    }
}
