using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoff_windows : MonoBehaviour
{
    public GameObject special1;
    public GameObject special2;
    public GameObject special3;
    public GameObject special4;
		
	// Start is called before the first frame update
    void Start()
    {
        
    }

	void OnEnable(){
		special1.SetActive(false);
		special2.SetActive(false);
		special3.SetActive(false);
		special4.SetActive(false);
	}	

    // Update is called once per frame
    void Update()
    {
        
    }
}
