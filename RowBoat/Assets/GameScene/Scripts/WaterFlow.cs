using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    [SerializeField] private float Force = 0.0f; // 力

    /// <summary>
    /// 水流の取得
    /// </summary>
    /// <returns>水流の力</returns>
    public Vector3 GetWaterFlow()
    {
        Vector3 dir = Vector3.forward;
        return dir * Force;
    }
}
