using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_Email : MonoBehaviour
{
	public GameObject emailClient;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void OnMouseDown(){
		//close videos
		GameObject currEmail = GameObject.FindGameObjectWithTag("email");
		if (currEmail != null){
			currEmail.SetActive(false);
		}
		emailClient.SetActive(false);

	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
