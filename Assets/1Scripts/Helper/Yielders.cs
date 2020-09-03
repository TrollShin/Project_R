using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Yielders
{
    static Dictionary<float, WaitForSeconds> timeInterval = new Dictionary<float, WaitForSeconds>();

    public static readonly WaitForEndOfFrame WaitForEndOfFrame = new WaitForEndOfFrame();

    public static WaitForSeconds Get(float sec)
    {
        if (!timeInterval.ContainsKey(sec)) timeInterval.Add(sec, new WaitForSeconds(sec));
        return timeInterval[sec];
    }
}
