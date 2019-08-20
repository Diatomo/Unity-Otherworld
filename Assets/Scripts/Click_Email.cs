using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Email : MonoBehaviour
{

	private string sGreen = "green_dot";
	private string sOrange = "orange_dot";
	private Sprite orange;
	private Sprite green;

	public GameObject dot;
	public GameObject email;

	//click vars
    private bool one_click;
    private float timer_for_double_click;
    private float delay;
    private float timeOut;


    // Start is called before the first frame update
    void Start()
    {
		orange = Resources.Load<Sprite>(sOrange);
		green = Resources.Load<Sprite>(sGreen);

		//click vars
        one_click = false;
        delay = 0.1f;
        timeOut = 1;
    }

	//onEvent :: calls parent
	public void OnEvent(string evnt){
		dot.GetComponent<SpriteRenderer>().sprite = green;
		
		//close videos
		GameObject currEmail = GameObject.FindGameObjectWithTag("email");
		if (currEmail != null){
			currEmail.SetActive(false);
		}
		email.SetActive(true);
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
