using UnityEngine;
using System.Collections;
    
    public class Click : MonoBehaviour{

	//click vars
    private bool one_click;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;

    void Start(){
		//click vars
        one_click = false;
        delay = 0.1f;
        timeOut = 1;
    }

	//onEvent :: calls parent
	public void OnEvent(string evnt){
		GameObject obj = this.transform.parent.gameObject;
		print(obj.tag);
		if (obj.tag == "folder" || obj.tag == "root"){
				obj.GetComponent<Foldir>().OnEvent(evnt);
		}
		else if (obj.tag == "scaffold"){
				print("scaffold event");
				obj.GetComponent<Click>().OnEvent(evnt);

		}
		else if (obj.tag == "file"){
				obj.GetComponent<File>().OnEvent(evnt);
		}
		else if (obj.tag == "password"){
				obj.GetComponent<Enter_Password>().OnEvent(evnt);
		}
		else if (obj.tag == "directory"){
				print("directory event");
				obj.GetComponent<Directory>().OnEvent(evnt);
		}
		else if (obj.tag == "text"){
				print("text");
				obj.GetComponent<Click_Text>().OnEvent(evnt);
		}
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

    //update method
    void Update(){
		reset();
    }
}
