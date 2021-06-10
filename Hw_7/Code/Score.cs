using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;


internal sealed class Score : MonoBehaviour
{
    [SerializeField]private GameObject _scoretext;
    private int Count;
    private int _score;

    private void SumScore()
    {
        Count = Count += 1000;
        if (Count<1000) {
            _scoretext.GetComponent<Text>().text = "Score: " + Count.ToString();
        }
        else
        {
            _score = Count / 1000;
_scoretext.GetComponent<Text>().text = "Score: " + _score.ToString() + "K";
        }
    }
    private void Update()
    {
        SumScore();
    }
    
}
