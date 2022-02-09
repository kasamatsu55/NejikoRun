using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public NejikoController nejiko;
    public Text scoreText;
    public LifePanel lifePanel;

    // Update is called once per frame
    public void Update()
    {
        //スコアを更新
        int score = CalcScore();
        scoreText.text = $"Score{score}m";
        //scoreText.fontSize = 30;で文字サイズも操作できる

        //ライフパネルを更新
        lifePanel.UpdateLife(nejiko.Life());
    }

    int CalcScore()
    {
        //ねじ子の走行距離をスコアとする
        return (int)nejiko.transform.position.z;
    }
}
