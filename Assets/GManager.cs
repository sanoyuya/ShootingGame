using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    //敵の数を数える用の変数
    private GameObject[] enemy;
    private GameObject[] addEnemy;

    //パネルを登録する
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
        //60Fに固定
        Application.targetFrameRate = 60;

        //パネルを隠す
        panel.SetActive(false);
        //敵を隠す
        AddEnemy1.SetActive(false);
        AddEnemy2.SetActive(false);
        AddEnemy3.SetActive(false);
        AddEnemy4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        addEnemy = GameObject.FindGameObjectsWithTag("AddEnemy");

        //シーンに1匹もEnemyがいなくなったら
        if (enemy.Length == 0 && addEnemy.Length == 0 && time == 301)
        {
            //パネルを表示させる
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
