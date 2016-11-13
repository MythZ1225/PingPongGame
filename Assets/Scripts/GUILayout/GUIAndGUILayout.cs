using UnityEngine;
using System.Collections;

public class GUIAndGUILayout : MonoBehaviour {

    void OnGUI()
    {
        // Fixed Layout
        GUI.Button(new Rect(25, 25, 100, 30), "I am a Fixed Layout Button");

        // Automatic Layout
        GUILayout.Button("I am an Automatic Layout Button");
    }

}
