using UnityEngine;
using System.Collections;

public class updownobstacle : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float height;
    private Vector3 left;
    private Vector3 right;

    void Update()
    {
        left = new Vector3(x, y, z);
        right = new Vector3(x, y + height, z);
        transform.position = Vector3.Lerp(left, right, Mathf.PingPong(Time.time * 1f, 1.0f));
    }
}
