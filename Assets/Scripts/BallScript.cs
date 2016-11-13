using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forceY = 500;
    public float forceX = 500;
    // Use this for initialization
    public static int Numball = 0;
    public AudioClip[] BallHitAudio = new AudioClip[] { };
    public void Die()
    {

        if (Numball == 1) //場上沒有球
        {
            GameObject playerPad = GameObject.Find("PlayerPad");
            Playerpad playerPadScript = playerPad.GetComponent<Playerpad>();
            playerPadScript.LoseLife();
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }

    void Start()
    {
        Numball++;
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0, forceY, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BallIntDecrease()
    {
        Numball--;
        //Debug.Log("Numball " + Numball);
    }

    public void ResetBallNum()
    {
        Numball = 1;
    }

    public void OnCollisionEnter(Collision col)
    {
        int random = Random.Range(0, BallHitAudio.Length);
        AudioSource.PlayClipAtPoint(BallHitAudio[random], this.transform.position);       
    }
}