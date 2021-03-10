using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score1;
    public TMPro.TextMeshProUGUI score2;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        score1.text = "Player1: " + PlayerPrefs.GetInt("Player1Score");
        score2.text = "Player2: " + PlayerPrefs.GetInt("Player2Score");
    }
}
