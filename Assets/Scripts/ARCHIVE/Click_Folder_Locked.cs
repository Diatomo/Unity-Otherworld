using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Folder_Locked : MonoBehaviour
{
    // initial
    public GameObject objSelect;
    public GameObject directory;
	//public GameObject locked;
	private Click_Folder_Container active;

    public bool selected;
	private bool locked;
    private bool one_click;
    private bool timer_running;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;

    void Start(){
        one_click = false;
        selected = false;
		locked = true;
        delay = 0.1f;
        timeOut = 1;
		active = directory.GetComponent<Click_Folder_Container>();
    }

    private void changeSelection(){
        if (!selected){
            objSelect.SetActive(true);
            selected = true;
        }
        else if (selected){
            objSelect.SetActive(false);
            selected = false;
        }
    }

	private void unlock(){


	}

    //set Active when pressed
    void OnMouseDown(){
        if (!one_click){
            one_click = true;
            changeSelection();
            timer_for_double_click = Time.time;
        }
        if (one_click){
            print(Time.time - timer_for_double_click);
            if ((Time.time - timer_for_double_click > delay)){
					if(locked){
						unlock();
					}

					else{
						directory.transform.position = new Vector3(0,0,0);
						active.selected = true;
						changeSelection();
						one_click = false;
					}
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
