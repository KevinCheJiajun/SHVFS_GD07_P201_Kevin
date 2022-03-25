using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hackman_GD07
{
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
        public static IntVector2 operator +(IntVector2 v1, IntVector2 v2)
        {
            return new IntVector2(v1.x + v2.x, v1.y + v2.y);
        }
        public static IntVector2 operator -(IntVector2 v)
        {
            return new IntVector2(-v.x, -v.y);
        }
        public static bool operator ==(IntVector2 v1, IntVector2 v2)
        {
            return (v1.x == v2.x && v1.y == v2.y);
        }
        public static bool operator !=(IntVector2 v1, IntVector2 v2)
        {
            return (v1.x != v2.x || v1.y != v2.y);
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
    public class BaseGridMovement : BaseGridObject
    {
        public float MoveSPeed;
        protected IntVector2 targetGridPosition;
        public float progressToTarget = 1f;
        protected IntVector2 currentInputDirection;
        private IntVector2 priviousInputDirection;
        protected virtual void Update()
        {
            if (transform.position == targetGridPosition.ToVector3())
            {
                progressToTarget = 0f;
                GridPosition = targetGridPosition;
            }
            if (GridPosition == targetGridPosition
                && LevelGeneratorSystem.Grid[Mathf.Abs(GridPosition.y + currentInputDirection.y), Mathf.Abs(GridPosition.x + currentInputDirection.x)] != 1)
            {
                targetGridPosition += currentInputDirection;
            }
            else if ()
            {

            }
        }
    }
}


