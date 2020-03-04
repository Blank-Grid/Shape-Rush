using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Xml;

public class GameManager : MonoBehaviour {
    //属性
    private bool isGameOver = false;  //游戏状态
    private int score = 0;  //玩家分数
    private int life = 1;  //玩家初始生命值
    public Text scoreText;  //分数显示
    public Text lifeText;  //生命值显示

    // Use this for initialization
    //游戏分数
    void Getscore(float score)
    {
        while (true)
        { 
            score = score + Time.time;
            scoreText.text = score.ToString();
        }
        
    }
    //游戏开始
    void Start() {

    }

    // Update is called once per frame
    //状态更新
    void Update()
    {
        //判断游戏状态
        if (isGameOver) return;
        //按Esc退出游戏
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            isGameOver = true;
        }
        //按空格键暂停
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
        //判断是否与目标几何图形相同
        //若不同，life-1
        /*if()//目标图形是否与玩家图形相同，不同
        {
            if(life > 1)
            {
                life--;
                lifeText.text = life.ToString();
                if (life == 0)
                {
                    isGameOver = true;
                    return;
                }
            }
            
        }
        if()//相同
        {
            isGameOver = false;
            life++;
            lifeText.text = life.ToString();
        }


    }*/
        

    }
    //游戏结束
    public void GameOver()
    {
        if (isGameOver) return;

    }

    private void CreateSaveGO()
    {
        Save save = new Save();
    }
    //游戏保存
    private void Save()
    {
        //Save save = CreateSaveGO();
        //xml文件保存路径
        string filepath = Application.dataPath + "/Streamingfile" + "/data.txt";
        //创建xml文档
        XmlDocument xmlDoc = new XmlDocument();
        //创建根节点
        XmlElement root = xmlDoc.CreateElement("save");
        //设置根节点的值
        root.SetAttribute("name", "Rank");

        XmlElement score;
        XmlElement player;
    }
    //游戏存档读取，排行榜
    private void Load()
    {

    }
}

