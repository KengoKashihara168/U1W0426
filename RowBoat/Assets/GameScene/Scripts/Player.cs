using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float MoveTime = 0.0f;
    [SerializeField] private Vector3 MoveDistance = Vector3.zero;
    private float _elapsedTime;
    private Vector3 _moveDistance;

    public void Initialize()
    {
        Debug.Log("プレイヤーの初期化");
        _elapsedTime = 0.0f;
        _moveDistance = Vector3.zero;
    }

    /// <summary>
    /// プレイヤーの更新
    /// </summary>
    public void UpdatePlayer()
    {
        // 移動
        Move();
    }

    /// <summary>
    /// 移動
    /// </summary>
    /// <param name="dir">移動方向</param>
    public void SetDirection(Vector3 dir)
    {
        if (_elapsedTime > 0.0f) return;
        _elapsedTime = MoveTime;
        Vector3 direction = dir.normalized + Vector3.forward;
        _moveDistance = Vector3.Scale(MoveDistance,direction);
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        if(_elapsedTime <= 0.0f) return;
        _elapsedTime -= Time.deltaTime;
        float time = Time.deltaTime / MoveTime;
        Vector3 vel = _moveDistance * time;
        transform.position += vel;
    }


}
