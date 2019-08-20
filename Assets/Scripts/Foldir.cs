using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class Foldir : MonoBehaviour
{
	
	public GameObject targetDir;
	public GameObject currDir;
	public GameObject pwBox;
	public bool locked;


	public GameObject image_viewerA;
	public GameObject image_viewerB;
	public GameObject text_viewerA;
	public GameObject text_viewerB;
	public GameObject moviePlayer;
	public GameObject[] maximumImages;

    // Start is called before the first frame update
    void Start(){
		if (locked == null){
			locked = false;
		}
    }

	public void OnEvent(string evnt){
		if (evnt == "open"){
				if (locked){
					pwBox.SetActive(true);
				}
				else{
					closeAll();
					targetDir.SetActive(true);
					print("calling event");
					if (gameObject.tag != "root"){
							GameObject obj = transform.parent.gameObject;
							obj.GetComponent<Directory>().OnEvent("close");
					}
				}
		}
		if (evnt == "unlock"){
			locked = false;
			pwBox.SetActive(false);
		}
	}

	public void closeAll(){

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

		//close directories
		GameObject currEmail = GameObject.FindGameObjectWithTag("email");
		if (currEmail != null){
			currEmail.SetActive(false);
		}

		image_viewerA.SetActive(false);
		image_viewerB.SetActive(false);
		text_viewerA.SetActive(false);
		text_viewerB.SetActive(false);
		moviePlayer.SetActive(false);

	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
