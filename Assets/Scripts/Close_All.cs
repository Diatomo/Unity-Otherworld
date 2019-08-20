using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class Close_All : MonoBehaviour
{
    
	
	public GameObject image_viewerA;
	public GameObject image_viewerB;
	public GameObject text_viewerA;
	public GameObject text_viewerB;
	public GameObject audioPlayer;

	public GameObject[] maximumImages;
	// Start is called before the first frame update
    void Start()
    {
        
    }

	void onMouseDown(){
		
		print("is this working");
		//close images
      	maximumImages = GameObject.FindGameObjectsWithTag("maxImage");
		foreach (GameObject image in maximumImages){
			image.SetActive(false);
		}
			
		//close videos
		GameObject vid = GameObject.FindGameObjectWithTag("video");
		if (vid != null){
			vid.GetComponent<VideoPlayer>().Stop();
			vid.SetActive(false);
		}
		
		//close directories
		GameObject dir = GameObject.FindGameObjectWithTag("directory");
		if (dir != null){
			dir.SetActive(false);
		}

		//close roots
		GameObject root = GameObject.FindGameObjectWithTag("root");
		if (root != null){
			root.SetActive(false);
		}
		image_viewerA.SetActive(false);
		image_viewerB.SetActive(false);
		text_viewerA.SetActive(false);
		text_viewerB.SetActive(false);
		audioPlayer.SetActive(false);



	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
