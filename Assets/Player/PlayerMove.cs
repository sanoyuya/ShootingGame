using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.2f;
        }
        else
        {
            speed = 0.1f;
        }

        //右矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //右方向に0.01動く
            pos.x += speed;
        }
        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //左方向に0.01動く
            pos.x -= speed;
        }
        //上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //右方向に0.01動く
            pos.z += speed;
        }
        //下矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //右方向に0.01動く
            pos.z -= speed;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
