using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public static class GUtils
    {

        public static Vector3 GetRangomDir()
        {
            return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        }
    }
}