using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Image_Viewer : MonoBehaviour{
 
	public GameObject directory;
	public GameObject[] maximumImages;
     
	// Start is called before the first frame update
    void Start()
    {

    }

	void OnMouseDown(){
      	maximumImages = GameObject.FindGameObjectsWithTag("maxImage");
		foreach (GameObject image in maximumImages){
			image.SetActive(false);
		}
		directory.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
