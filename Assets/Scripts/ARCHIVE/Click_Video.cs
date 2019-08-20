using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class Click_Video : MonoBehaviour
{
    // initial
    public GameObject video;
	public GameObject mediaPlayer;

	//click vars
    private bool one_click;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;

    void Start(){
		//click vars
        one_click = false; 
        delay = 0.1f; //delay between clicks
        timeOut = 1; //timeout after 1 second
    }

    //set Active when pressed
    void OnMouseDown(){
        if (!one_click){
            one_click = true;
            timer_for_double_click = Time.time;
        }
		else if (one_click){
            if ((Time.time - timer_for_double_click > delay)){
				video.SetActive(true);
				video.GetComponent<VideoPlayer>().Play();
				mediaPlayer.SetActive(true);
				this.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
                one_click = false;
            }
        }
    }


    //update method
    void Update(){
        if ((Time.time - timer_for_double_click > timeOut))
        {
            one_click = false;
        }
    }
}
