using UnityEngine;
using System.Collections;

public class GUILayoutOptions : MonoBehaviour {

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100, 50, Screen.width - 200, Screen.height - 100));
        GUILayout.Button("I am a regular Automatic Layout Button");
        GUILayout.Button("My width has been overridden", GUILayout.Width(95));
        GUILayout.EndArea();
    }

}
