using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameName : MonoBehaviour
{
    public Text highScore;

    public void Update()
    {
        highScore.text = PlayerName.ShowName + "'s Score: ";
    }
}