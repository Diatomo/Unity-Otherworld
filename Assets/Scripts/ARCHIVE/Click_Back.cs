using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Back : MonoBehaviour
{
   public GameObject prevDirectory;

	// Start is called before the first frame update
    void Start()
    {

    }

	void OnMouseDown(){
		this.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
		prevDirectory.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
