using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    
    [SerializeField] GameObject gameOverText;
    [SerializeField] TextMeshProUGUI scoreText;


    private int score = 0;
    public static gameManager instance;
    public bool isGameOver = false;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit") && isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void InstantiateGameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
