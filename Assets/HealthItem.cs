using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour, Iitem
{
    public int healAmount = 1;
    public static event Action<int> onHealthCollect;

    public void Collect()
    {
        onHealthCollect.Invoke(healAmount);
        Destroy(gameObject);
    }
}
