using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Pause
{
    //False = unpaused
    private static bool pause = false;

    public static void setPause(bool isPaused)
    {
        pause = isPaused;
    }

    public static bool getPaused()
    {
        return pause;
    }
}
