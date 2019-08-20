using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Text : MonoBehaviour
{


    // initial
    public GameObject content;
	public GameObject viewer;

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

	public void OnEvent(string evnt){
		if (evnt == "open"){
				viewer.SetActive(true);
				content.SetActive(true);
				GameObject obj = transform.parent.gameObject;
				obj.GetComponent<Directory>().OnEvent("close");
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
