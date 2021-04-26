using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigid;

    public void Initialize()
    {
        Debug.Log("プレイヤーの初期化");
        _rigid = GetComponent<Rigidbody>();
    }

    public void UpdatePlayer()
    {
        Debug.Log("プレイヤーの更新");
    }

    /// <summary>
    /// 移動
    /// </summary>
    /// <param name="dir">方向</param>
    public void Move(Vector3 dir)
    {
        Vector3 normal = dir.normalized;

        _rigid.AddForce(normal * 20.0f);
    }
}
