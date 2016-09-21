using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public int scoreValue = 0;
    public TextMesh scoreboard;
    public TextMesh ballCount;
    public GameObject ball;
    public GameObject launcher;
    public GameObject[] launchers;
    public static int balls = 8;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        launchers = GameObject.FindGameObjectsWithTag("Launcher");
        foreach (GameObject launch in launchers)
        {
            Destroy(launch);
        }
        scoreboard.text = (int.Parse(scoreboard.text) + scoreValue).ToString().PadLeft(4,'0');
        if (scoreValue != 0)
        {
            ballCount.text = "BALLS: " + (--balls).ToString();
        }
        if (balls == 0)
        {
            if (int.Parse(scoreboard.text) >= 3000)
            {
                Application.LoadLevel("win");
            }
            else
            {
                Application.LoadLevel("lose");
            }
        }
            Instantiate(launcher, new Vector3(0.011f, 0.393f, -10.721f), transform.rotation);
            Invoke("Reload", 3);
    }
}
