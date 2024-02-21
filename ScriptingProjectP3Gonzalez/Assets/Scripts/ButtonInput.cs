using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

  

    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        
        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}