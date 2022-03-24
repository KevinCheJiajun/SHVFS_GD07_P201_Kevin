using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct IntVector2
{
    public int x;
    public int y;

    public static IntVector2 zero => new IntVector2(0, 0);

    public IntVector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
public class BaseGridObject : MonoBehaviour
{
    public IntVector2 GridPosition;
    public Vector2Int GridPos;

    private void OnEnable()
    {
        var whatever = Vector2Int.zero;

        var whateverAlso = new Vector2Int(0, 0);

        var whateverAgain = IntVector2.zero;
    }

}


