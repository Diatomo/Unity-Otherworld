using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class newMessage : MonoBehaviour{


	//click vars
    private bool one_click;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;

	public GameObject image;
	public GameObject audioPlayer;

    // Start is called before the first frame update
    void Start(){
		//click vars
        one_click = false;
        delay = 0.1f;
        timeOut = 1;
    }

	private void OnEnable(){
		Text txt = GetComponentInChildren<Text>();
		txt.text = "1 Message";
	}

	//onEvent :: calls parent
	public void OnEvent(string evnt){
		Text txt = GetComponentInChildren<Text>();
		txt.text = "0 Messages";
		GetComponentInChildren<Scifi_Animation>().enabled = true;
		GetComponentInChildren<blink>().enabled = false;
	}

	//dbl click event
    void OnMouseDown(){

		//check one_click
        if (!one_click){
            one_click = true;
            timer_for_double_click = Time.time;
        }

		//check double_click
        if (one_click){
            if ((Time.time - timer_for_double_click > delay)){
        		this.OnEvent(this.tag);    
			}
        }
    }

	//reset timer if inactive
	void reset(){
        if ((Time.time - timer_for_double_click > timeOut)){
            one_click = false;
        }
	}

    // Update is called once per frame
    void Update(){
		reset();	
    }
}
