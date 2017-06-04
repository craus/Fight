using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class LimitedInt
{
    public int value;
    public int maxValue;

    public override string ToString() {
        return string.Format("{0}/{1}", value, maxValue);
    }
}
