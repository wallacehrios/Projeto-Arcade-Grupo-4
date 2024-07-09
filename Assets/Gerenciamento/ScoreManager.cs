using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public GameObject TelaDerrota;
    int score = 0;
    int boss = 0;
    int bossGoal = 1;
    public int scoreGoal = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + " PONTOS";
        TelaDerrota.SetActive(false);
    }
    void Update()
    {
        if (score >= scoreGoal){
            score = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           }
        if (boss >= bossGoal)
           {
            boss = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene("VictoryScreen");
           }
    }
    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " PONTOS";
    }
    public void BossMorto()
    {
        boss += 1;
    }
    public void Lose()
    {
        TelaDerrota.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReiniciarFase1()
    {
        SceneManager.LoadScene("PrimeiraFase");
        Time.timeScale = 1f;
    }
    public void ReiniciarFase2()
    {
        SceneManager.LoadScene("SegundaFase");
        Time.timeScale = 1f;
    }
    public void ReiniciarBossFight()
    {
        SceneManager.LoadScene("Boss Fight");
        Time.timeScale = 1f;
    }
}
