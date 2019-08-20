using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Back_Image : MonoBehaviour
{

   public GameObject prevDirectory;
   private GameObject[] maximumImages;

	// Start is called before the first frame update
    void Start()
    {

    }

	void OnMouseDown(){
      	maximumImages = GameObject.FindGameObjectsWithTag("maxImage");
		this.transform.parent.gameObject.SetActive(false);
		prevDirectory.SetActive(true);
		foreach (GameObject image in maximumImages){
			image.SetActive(false);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
