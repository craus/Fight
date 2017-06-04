using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class RangedInt
{
    public int minValue;
    public int maxValue;

    public override string ToString() {
        return string.Format("{0}-{1}", minValue, maxValue);
    }
}
