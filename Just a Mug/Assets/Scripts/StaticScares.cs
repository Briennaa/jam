using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticScares
{
    public static void setScared(Animator ani, int num)
    {
        ani.SetInteger("skin", num);
    }
}
