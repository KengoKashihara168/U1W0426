using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 0.0f; // 移動速度
    [SerializeField] private float TorqueForce = 0.0f; // 回転力
    private Rigidbody _rigid;

    public void Initialize()
    {
        Debug.Log("プレイヤーの初期化");
        _rigid = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 左へ移動
    /// </summary>
    public void MoveLeft()
    {
        _rigid.AddTorque(Vector3.up * -TorqueForce);
        _rigid.AddForce(Vector3.forward * MoveSpeed);
    }

    /// <summary>
    /// 右へ移動
    /// </summary>
    public void MoveRight()
    {
        _rigid.AddTorque(Vector3.up * TorqueForce);
        _rigid.AddForce(Vector3.forward * MoveSpeed);
    }
}
