using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameState gameState = GameState.Stopped;
    public int score;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        gameState = GameState.Playing;
        StartCoroutine(IncrementScore());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator IncrementScore()
    {
        while (gameState == GameState.Playing)
        {
            score++;
            UiManager.instance.DisplayScoreVisuals(score);
            print(score);
            yield return new WaitForSeconds(1f);
        }
    }
}
