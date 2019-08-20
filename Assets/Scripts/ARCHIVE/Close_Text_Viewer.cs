using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Text_Viewer : MonoBehaviour
{
	public GameObject directory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnMouseDown(){
		//close video
		GameObject text = GameObject.FindGameObjectWithTag("text_view");
		if (text != null){
			text.SetActive(false);
		}
		directory.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
