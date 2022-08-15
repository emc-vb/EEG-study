using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UI_instruction : MonoBehaviour
{
    public TextMeshProUGUI introductionText;

    private string _instructionText = "Welcome to our experiment, in the following scene you will walk through an environment, please just follow the path in one direction";

    private float _timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        introductionText.text = _instructionText;
    }

    // Update is called once per frame
    void Update()
    {
        _timer++;

        if (_timer == 1500)
        {
            introductionText.text = " ";
        }
    }
}
