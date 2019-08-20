using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Close_Menu : MonoBehaviour
{
    // initial
    public GameObject directory;

    void Start(){

    }

	//closes directory
    void OnMouseDown(){
        directory.SetActive(false);
    }

    //update method
    void Update(){
    }
}
