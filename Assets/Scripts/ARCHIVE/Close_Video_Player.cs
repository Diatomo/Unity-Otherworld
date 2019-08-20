using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class Close_Video_Player : MonoBehaviour
{
	public GameObject directory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnMouseDown(){
		//close video
		GameObject vid = GameObject.FindGameObjectWithTag("video");
		if (vid != null){
			vid.GetComponent<VideoPlayer>().Stop();
			vid.SetActive(false);
		}
		directory.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {

    }
}
