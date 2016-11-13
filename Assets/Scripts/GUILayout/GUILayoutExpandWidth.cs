using UnityEngine;
using System.Collections;

public class GUILayoutExpandWidth : MonoBehaviour {

    void OnGUI()
    {
        GUILayout.BeginVertical();
        GUILayout.Button("Short Button", GUILayout.ExpandWidth(false));
        GUILayout.Button("Very very long Button");
        GUILayout.EndVertical();
    }
}
