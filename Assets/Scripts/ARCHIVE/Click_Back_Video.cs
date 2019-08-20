using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class Click_Back_Video : MonoBehaviour
{
   public GameObject prevDirectory;
   //public GameObject video;

	// Start is called before the first frame update
    void Start()
    {

	}

	void OnMouseDown(){

		//close video
		GameObject vid = GameObject.FindGameObjectWithTag("video");
		vid.GetComponent<VideoPlayer>().Stop();
		vid.SetActive(false);
		
		//route directory
		this.transform.parent.gameObject.SetActive(false);
		prevDirectory.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
        
}
