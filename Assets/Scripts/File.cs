using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : MonoBehaviour
{

	public GameObject image;
	public GameObject imageViewer;

    // Start is called before the first frame update
    void Start()
    {
        
	}

	public void OnEvent(string evnt){
		if (evnt == "open"){
			image.SetActive(true);
			imageViewer.SetActive(true);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
