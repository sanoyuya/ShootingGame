using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    //�G�̐��𐔂���p�̕ϐ�
    private GameObject[] enemy;
    private GameObject[] addEnemy;

    //�p�l����o�^����
    public GameObject panel;

    public GameObject AddEnemy1;
    public GameObject AddEnemy2;
    public GameObject AddEnemy3;
    public GameObject AddEnemy4;
    int time = 300;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        //60F�ɌŒ�
        Application.targetFrameRate = 60;

        //�p�l�����B��
        panel.SetActive(false);
        //�G���B��
        AddEnemy1.SetActive(false);
        AddEnemy2.SetActive(false);
        AddEnemy3.SetActive(false);
        AddEnemy4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[���ɑ��݂��Ă���Enemy�^�O�������Ă���I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        addEnemy = GameObject.FindGameObjectsWithTag("AddEnemy");

        //�V�[����1�C��Enemy�����Ȃ��Ȃ�����
        if (enemy.Length == 0 && addEnemy.Length == 0 && time == 301)
        {
            //�p�l����\��������
            panel.SetActive(true);
        }

        if (Input.GetKey(KeyCode.R))
        {
            string activeSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(activeSceneName);
        }

        if (time <= 300)
        {
            time--;
        }
       
        if (time < 0)
        {
            AddEnemy1.SetActive(true);
            AddEnemy2.SetActive(true);
            AddEnemy3.SetActive(true);
            AddEnemy4.SetActive(true);
            time = 301;
        }
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
