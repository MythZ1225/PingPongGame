using UnityEngine;
using System.Collections;

public class GUILayoutSpace : MonoBehaviour {

    void OnGUI()
    {
        GUILayout.Button("I'm the first button");
        GUILayout.Space(20);
        GUILayout.Button("I'm a bit further down");

        //GUILayout.Space(30);

        GUILayout.BeginHorizontal();
        GUILayout.Button("I'm the first button");
        GUILayout.Space(20);
        GUILayout.Button("I'm the second button");
        GUILayout.Space(50);
        GUILayout.Button("I'm the 3rd button");
        GUILayout.EndHorizontal();
    }


}
