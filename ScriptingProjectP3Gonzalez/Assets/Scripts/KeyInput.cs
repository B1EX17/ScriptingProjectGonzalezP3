using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;



    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if (down)
        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}