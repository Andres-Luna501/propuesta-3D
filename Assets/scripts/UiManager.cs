using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI CurrentScoreText;
    public TextMeshProUGUI BestScoreText;

    void Update()
    {
        CurrentScoreText.text = "Score: " + GameManager.singleton.currentScore;

        BestScoreText.text = "Best: " + GameManager.singleton.bestScore;
    }
}