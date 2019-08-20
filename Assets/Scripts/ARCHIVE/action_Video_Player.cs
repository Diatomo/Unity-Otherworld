using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action_Video_Player : MonoBehaviour
{
	GameObject[] dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable(){

		dir = GameObject.FindGameObjectsWithTag("directory");
		foreach (GameObject thing in dir){
			thing.SetActive(false);
		}

    }

    void OnDisable(){
		foreach (GameObject thing in dir){
			thing.SetActive(true);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
