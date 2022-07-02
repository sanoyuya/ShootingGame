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
        //�v���C���[�̃��[���h���W���擾
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.2f;
        }
        else
        {
            speed = 0.1f;
        }

        //�E���L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //�E������0.01����
            pos.x += speed;
        }
        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //��������0.01����
            pos.x -= speed;
        }
        //����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //�E������0.01����
            pos.z += speed;
        }
        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //�E������0.01����
            pos.z -= speed;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
