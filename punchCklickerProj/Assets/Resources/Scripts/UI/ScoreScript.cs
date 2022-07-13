using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    private int _score;
    void Awake()
    {
        _scoreText = this.gameObject.GetComponent<Text>();
        _score = 0;
        _scoreText.text = _score.ToString();
        EventManager.Instance.updateScore.AddListener(UpdateScore);

    }
    private void UpdateScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}
