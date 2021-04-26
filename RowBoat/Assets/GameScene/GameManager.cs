using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player _player = null; // プレイヤー

    // Start is called before the first frame update
    void Start()
    {
        _player.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        _player.UpdatePlayer();

        // プレイヤーの移動
        float x = Input.GetAxis("Horizontal");
        _player.Move(new Vector3(x,0.0f,0.0f));
    }
}
