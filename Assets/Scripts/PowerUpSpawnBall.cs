using UnityEngine;
using System.Collections;

public class PowerUpSpawnBall : MonoBehaviour {



    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        GameObject playerPad = GameObject.Find("PlayerPad");
        Playerpad playerPadScript = playerPad.GetComponent<Playerpad>();
        playerPadScript.spawnBall();
        playerPadScript.BallShotOut();
    }
}
