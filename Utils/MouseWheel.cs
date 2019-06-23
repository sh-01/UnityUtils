## MouseWheel.cs (You should copy) ##

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWheel : MonoBehaviour
{
    public static bool ScrollUp;
    public static bool ScrollDown;
    private void Update()
    {
        if (ScrollUp){ScrollUp = false;}
        if (ScrollDown){ScrollDown = false;}
        float scroll = Input.GetAxis("Mouse ScrollWheel") * 10;
        if (0 < scroll){ScrollDown = false;ScrollUp = true;} /* ScrollUp */
        if (0 > scroll){ScrollUp = false;ScrollDown = true;} /* ScrollDown */
    }
}


## IN MAIN CLASS (Example) ##

public class Main : Monobehavior
{
    void Upsate()
    {
        if (MouseWheel.ScrollUp)
        {
            print("Scroll up! and Zoom in!");
        }
        
        if (MouseWheel.ScrollDown)
        {
            print("Scroll down! and Zoom out!");
        }
    }
}
