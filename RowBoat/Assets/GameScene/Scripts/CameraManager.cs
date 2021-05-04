using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform  _target     = null; // ターゲット
    [SerializeField] private float      _distance   = 0.0f; // 距離

    /// <summary>
    /// カメラの更新
    /// </summary>
    public void UpdateCamera()
    {
        // ターゲットの追跡
        TrackTarget();
    }

    /// <summary>
    /// ターゲットの追跡
    /// </summary>
    private void TrackTarget()
    {
        Vector3 pos         = transform.position;
        pos.z               = _target.position.z - _distance;
        transform.position  = pos;
    }
}
