using UnityEngine;
using System.Collections;

public class GUILayoutBeginScrollView : MonoBehaviour
{
    public Vector2 scrollPosition;
    public string longString = "This is a long-ish string";

    void Start()
    {
        
    }

    void OnGUI()
    {
        //scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(Screen.width / 3), GUILayout.Height(Screen.height / 3));
        GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(Screen.width / 3), GUILayout.Height(Screen.height / 3));
        GUILayout.Label(longString);
        GUILayout.EndScrollView();

        if (GUILayout.Button("Clear"))
            longString = "";

        if (GUILayout.Button("Add More Text"))
            longString += "\nHere is another line";

    }
}
