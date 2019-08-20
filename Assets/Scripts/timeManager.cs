using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class timeManager : MonoBehaviour{

	private bool reset;
	private bool randEvnt;
	
	private float timeForReset;
	private float timeForEvent;

	private float resetTimer;
	private float eventTimer;

	private GameObject[] dirs;
	private GameObject[] vids; 
	private GameObject[] images;

	public GameObject evnt;
	public GameObject videoPlayer;
	public GameObject imageViewer;
	public GameObject audioPlayer;
	public GameObject documentViewer;

    // Start is called before the first frame update
    void Start(){
        reset = true;
		randEvnt = false;

		timeForReset = 60.0f*3.0f;
		timeForEvent = 60.0f*1.5f;

		resetTimer = 0.0f;
		eventTimer = 0.0f;

    }

	//check if mouse moved
	private bool checkForInput(){
		bool input = false;
		if(Input.GetAxis("Mouse X")<0 || Input.GetAxis("Mouse X")>0){
			input = true;
		}
		return input;
	}

	//keep and eye on inputs and increment reset timer
	private void inputWatcher(){
		bool input = checkForInput();
		if (input){
			//print("input");
			reset = false;
			resetTimer = 0.0f;
		}
		else{
			//print("no input");
			resetTimer += Time.deltaTime;
			if (resetTimer > timeForReset){
				restart();
			}
		}
	}

	//once first input wait to trigger event
	private void eventWatcher(){
		if (reset == false){
			eventTimer += Time.deltaTime;
			if (randEvnt == false){
				if (eventTimer > timeForEvent){
					turnOnEvent();
					randEvnt = true;
				}
			}
		}
	}


	private void turnOff(){

		vids = GameObject.FindGameObjectsWithTag("video");
		images = GameObject.FindGameObjectsWithTag("image");
		dirs = GameObject.FindGameObjectsWithTag("directory");
		if (vids != null){
			foreach (GameObject vid in vids){
				vid.GetComponent<VideoPlayer>().Stop();
			}	
		}

		if (images != null){
			foreach (GameObject image in images){
				image.SetActive(false);
			}
		}

		if (dirs != null){
			foreach (GameObject thing in dirs){
				thing.SetActive(false);
			}
		}

		videoPlayer.SetActive(false);
		imageViewer.SetActive(false);
		audioPlayer.SetActive(false);
		documentViewer.SetActive(false);
	}

	private void resetCoords(){
		dirs = GameObject.FindGameObjectsWithTag("directory");
		if (dirs != null){
			foreach (GameObject thing in dirs){
				Transform trans = thing.GetComponent<Transform>();
				trans.position = new Vector3(2,16,0);
			}
		}
	}

	private void turnOnEvent(){
		evnt.GetComponentInChildren<newMessage>().enabled = true;
		evnt.GetComponentInChildren<Scifi_Animation>().enabled = false;
		evnt.GetComponentInChildren<blink>().enabled = true;
	}

	private void restart(){
		resetCoords();
		randEvnt = true;
		turnOff();
	}

	private void rando(){
		turnOff();
		turnOnEvent();
	}

    // Update is called once per frame
    void Update(){
		inputWatcher();
		eventWatcher();
    }
}
