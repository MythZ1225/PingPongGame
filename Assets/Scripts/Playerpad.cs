using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Playerpad : MonoBehaviour {
    public float padSpeed = 10;
    public float angulaFactor = 300;
    public float firstBallForce = 300;
    public GameObject BallPrefab;
    GameObject attachBall;

    int Lives = 3;
    Text GUILive;
    public GameObject GameOverTexts;
    public GameObject GameOverPos;
    int Score = 0;
    public GUISkin ScoreBoardSkin;
    static GameObject GameoverClone;
    Rigidbody ballrig;

    //public int BallOnfield;

    // Use this for initialization 
    void Start () {
        //GameOverTexts = GameObject.Find("GameOver");

        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(GameObject.Find("Canvas"));
        
        //生一顆球
        GUILive = GameObject.Find("LivesText").GetComponent<Text>();
        GUILive.text = "Lives : " + Lives;
        spawnBall();

    }

    public void OnLevelLoaded(int level)
    {
        spawnBall();
    }

    public void LoseLife() {
        Lives--;
        GUILive.text = "Lives : " + Lives;
        if (Lives > 0)
        {
            spawnBall();
        }
        else
        {
            gameOverOn();
            Destroy(gameObject);            
        }
    }


    public void gameOverOn()
    {
        GameoverClone = Instantiate(GameOverTexts);
        GameoverClone.transform.position = GameOverPos.transform.position;
        GameoverClone.transform.SetParent(GameOverPos.transform); 
    }

    public void spawnBall()
    {

            if (BallPrefab == null)
            {
                Debug.Log("There is no ball");
            }
            else
            {
                attachBall = (GameObject)Instantiate(BallPrefab, transform.position, Quaternion.identity);
                //BallOnfield ++;
        }     
    }

    void OnGUI()
    {
        GUI.skin = ScoreBoardSkin;
        GUI.Label(new Rect(10, 3, 128, 34), "Score : "+ Score);
    }

    public void AddPoint(int v)
    {
        Score = Score + v;
    }

    // Update is called once per frame
    void Update () {
        //板子移動 
        float playpadMinPos = 8;
        if (transform.position.x > playpadMinPos)
        {
            transform.position = new Vector3(playpadMinPos, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -playpadMinPos)
        {
            transform.position = new Vector3(-playpadMinPos, transform.position.y, transform.position.z);
        }
        else {
            transform.Translate(padSpeed * Input.GetAxis("Horizontal"), 0, 0);
        }
        
        
        //第一次的球射出
        if (attachBall)
            {
            ballrig = attachBall.GetComponent<Rigidbody>();
            ballrig.position = transform.position+ new Vector3(0,0.9f,0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                BallShotOut();
            }
            
        }
       
    }

    public void BallShotOut()
    {
        ballrig = attachBall.GetComponent<Rigidbody>();
        ballrig.position = transform.position + new Vector3(0, 0.9f, 0);
        ballrig.isKinematic = false;
        //Debug.Log("space hit");
        ballrig.AddForce(firstBallForce * Input.GetAxis("Horizontal"), firstBallForce, 0);
        attachBall = null;
    }

    void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            if (contact.thisCollider == GetComponent<Collider>()) {
                float deltaX = contact.point.x - transform.position.x;
                contact.otherCollider.GetComponent<Rigidbody>().AddForce(angulaFactor * deltaX,0,0);
            }
        }
    }
}
