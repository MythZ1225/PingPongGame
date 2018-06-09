using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuGUIScript : MonoBehaviour {
    public float ButtonWidth = 100 ;
    public float ButtonHeight = 30 ;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect( Screen.width/2 - ButtonWidth/2 , Screen.height /2 , ButtonWidth, ButtonHeight*3));

        GUILayout.FlexibleSpace();
        if (GUILayout.Button("New Game"))
        {
            startLevel();
        }
        if (GUILayout.Button("Load Level"))
        {
            loadSelectLevel();
        }

        GUILayout.EndArea();
    }

    void startLevel()
    {
        //Application.LoadLevel(1);
        SceneManager.LoadScene(0);
        // Debug.Log("New Game");
    }

    void loadSelectLevel()
    {
        SceneManager.LoadScene(1);
        //Debug.Log("Load Level");
    }
}
