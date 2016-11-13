using UnityEngine;
using System.Collections;

public class GUILayoutSelectionGrid : MonoBehaviour {

    public int selGridInt = 0;
    public int xCount = 2;
    public string[] selStrings = new string[] { "radio1", "radio2", "radio3" };
    void OnGUI()
    {
        GUILayout.BeginVertical("Box");
        selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, xCount);
        if (GUILayout.Button("Start"))
            Debug.Log("You chose " + selStrings[selGridInt]);

        GUILayout.EndVertical();
    }
}
