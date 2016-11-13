using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bricks : MonoBehaviour {
    int scorePoints = 1;
    static int numBricks = 0;
    public string TagType;
    public int HitPoint=1 ;
    //public GameObject LevelManager;
    public string Nextlevel= "Level02";

    public GameObject PowerUpItem;

    float IsPowerUpChance;
    public float PowerUpChance;
    // Use this for initialization
    void Start () {
        scorePoints = HitPoint;
        numBricks++;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnCollisionEnter(Collision col)
    {
        HitPoint--;
        if (HitPoint <= 0)
        {
            Destroy(gameObject);
            IsPowerUpChance = Random.value;
            if (PowerUpChance > IsPowerUpChance) {
                powerUpDrop();
            }

            Playerpad playerPadScript = GameObject.Find("PlayerPad").GetComponent<Playerpad>();
            playerPadScript.AddPoint(scorePoints);
            //GameObject[] bricks =  GameObject.FindGameObjectsWithTag(TagType);
            numBricks--;
            Debug.Log(numBricks);
            if (numBricks <= 0)
            {
                SceneManager.LoadScene(Nextlevel);
                playerPadScript.spawnBall();
            }
        }
    }

    void powerUpDrop() {
        Instantiate(PowerUpItem,this.transform.position, Quaternion.identity );
    }

}
