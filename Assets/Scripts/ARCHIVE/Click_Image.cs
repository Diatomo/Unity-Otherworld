using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Click_Image : MonoBehaviour { 

    // initial
	public GameObject maxImage;
	public GameObject mediaViewer;

	//click vars	
	private bool one_click;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;



    void Start()
    {
	   	//click vars	
	one_click = false;
        delay = 0.1f;
        timeOut = 1;
    }
    
	
	private void view(){
	    if ((Time.time - timer_for_double_click > delay)){
				if (maxImage != null){
					maxImage.SetActive(true);
				}
				mediaViewer.SetActive(true);
			}
    }



    //set Active when pressed
    void OnMouseDown(){
		if (!one_click)
        {
            one_click = true;
            timer_for_double_click = Time.time;
        }
		else if (one_click)
        {
			this.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
			view();
        }
    }


    //update method
    void Update(){
        if ((Time.time - timer_for_double_click > timeOut)){
            one_click = false;
        }
    }
}
