using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum PlayerSide {
    Left,
    Right
}

public class GameController : MonoBehaviour
{
    public TMP_Text leftPlayerScoreUI;
    public TMP_Text rightPlayerScoreUI;

    private int leftPlayerScore;
    private int rightPlayerScore;

    // Start is called before the first frame update
    void Start()
    {
        leftPlayerScore = 0;
        rightPlayerScore = 0;
        leftPlayerScoreUI.text = leftPlayerScore.ToString();
        rightPlayerScoreUI.text = rightPlayerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(PlayerSide playerSide) {
        if (playerSide == PlayerSide.Left) {
            leftPlayerScore++;
            leftPlayerScoreUI.text = leftPlayerScore.ToString();
            return;
        }

        rightPlayerScore++;
        rightPlayerScoreUI.text = rightPlayerScore.ToString();
    }
}
