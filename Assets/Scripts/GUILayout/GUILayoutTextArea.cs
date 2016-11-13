using UnityEngine;
using System.Collections;

public class GUILayoutTextArea : MonoBehaviour {
    public string stringToEditTextField = "Hello World";
    public string stringToEditTextArea = "Hello World\nI've got 2 lines...";
    void OnGUI()
    {


        stringToEditTextField = GUILayout.TextField(stringToEditTextField, 25);

        stringToEditTextArea = GUILayout.TextArea(stringToEditTextArea, 200);


    }



}
