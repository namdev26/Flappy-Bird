using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _highScore;
    private int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentScore.text = _score.ToString();
        _highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        this.UpdateHightScore();
    }

    private void UpdateHightScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScore.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScore.text = _score.ToString();
        this.UpdateHightScore();
    }
}
