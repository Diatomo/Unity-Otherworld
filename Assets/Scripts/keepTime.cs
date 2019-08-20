using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class keepTime : MonoBehaviour
{

	private Text timekeep;
		
    // tart is called before the first frame update
    void Start()
    {
        timekeep = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       timekeep.text = DateTime.Now.ToString("hh:mm:ss tt");
    }
}
