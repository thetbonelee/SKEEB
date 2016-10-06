using UnityEngine;
using System.Collections;

public class sidetosideobstacle : MonoBehaviour
{

    public float x;
    public float y;
    public float z;
    public float width;
    private Vector3 left;
    private Vector3 right;

    void Update()
    {
        left = new Vector3(x, y, z);
        right = new Vector3(x+width, y, z);
        transform.position = Vector3.Lerp(left, right, Mathf.PingPong(Time.time/2 * 1.5f, 1.0f));
    }
}