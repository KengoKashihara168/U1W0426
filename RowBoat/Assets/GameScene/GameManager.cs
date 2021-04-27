using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ButtonManager  _buttonManager   = null; // ボタンマネージャー
    [SerializeField] private Player         _player          = null; // プレイヤー

    public delegate void ArrowClickedFunc(ButtonManager.ArrowType arrow); // 矢印が押されたときのデリゲート

    // Start is called before the first frame update
    void Start()
    {
        _player.Initialize();
        _buttonManager.SetArrowClickedFunc(ArrowClicked);
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    /// <summary>
    /// 矢印が押された
    /// </summary>
    /// <param name="arrow">押された矢印の種類</param>
    private void ArrowClicked(ButtonManager.ArrowType arrow)
    {
        switch(arrow)
        {
            case ButtonManager.ArrowType.Left:
            _player.MoveLeft();
            break;
            case ButtonManager.ArrowType.Right:
            _player.MoveRight();
            break;
        }
    }
}
