using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hackman_GD07;

public class GenericsExample : MonoBehaviour
{
    private void OnEnable()
    {
        //var animator = gameObject.GetComponent<Animator>();
        var pair = new Pair<int>() { First = 32, Second = 34 };

    }
}
public class Pair<T>
{
    public T First;
    public T Second;
}
