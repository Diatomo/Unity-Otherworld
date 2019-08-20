using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directory : MonoBehaviour
{
	public GameObject prevDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void OnEvent(string evnt){
		print("dir event");
		if (evnt == "close"){
			GameObject pw = GameObject.FindGameObjectWithTag("password");
			if (pw != null){
				pw.SetActive(false);
			}
			gameObject.SetActive(false);
		}
		else if (evnt == "back"){
			if (prevDir != null){
				prevDir.SetActive(true);
				gameObject.SetActive(false);
			}
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
