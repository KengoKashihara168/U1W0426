using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public enum ArrowType { Left, Right} // 矢印の種類

    private GameManager.ArrowClickedFunc _arrowClickedFunc;

    /// <summary>
    /// 矢印クリック時に呼び出す関数を設定
    /// </summary>
    /// <param name="func">矢印クリック時に呼び出す関数</param>
    public void SetArrowClickedFunc(GameManager.ArrowClickedFunc func)
    {
        _arrowClickedFunc = func;
    }

    /// <summary>
    /// 左矢印ボタンのイベントハンドラ
    /// </summary>
    public void OnLeftArrowButton()
    {
        Debug.Log("左矢印が押された");
        _arrowClickedFunc(ArrowType.Left);
    }

    /// <summary>
    /// 右矢印ボタンのイベントハンドラ
    /// </summary>
    public void OnRightArrowButton()
    {
        Debug.Log("右矢印が押された");
        _arrowClickedFunc(ArrowType.Right);
    }
}
