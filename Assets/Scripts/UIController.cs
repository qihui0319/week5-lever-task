﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text message1;
    public Text message2;
    public Text message3;

    public PlayerBehaviour player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        message1.text = "You Stones : " + player.myPoints;
        message2.text = "Your Lives : " + player.lives ;
        message3.text = "Time Left:" + player.levelDuration;
    }
}
