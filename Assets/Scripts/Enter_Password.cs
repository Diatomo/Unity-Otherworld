using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enter_Password : MonoBehaviour
{

	public string correctPassword;
	public InputField input;

    // Start is called before the first frame update
    void Start(){

    }

	private void checkpassword(){
		//get password
		GameObject txtObj = GameObject.FindGameObjectWithTag("input");
		string currentPassword = txtObj.GetComponent<Text>().text;
		if (currentPassword ==  correctPassword){
			GameObject obj = this.transform.parent.gameObject;
			obj.GetComponent<Foldir>().OnEvent("unlock");
		}
		else{
			input.text = "incorrect";
		}
	}

    public void OnEvent(string evnt){
		print(evnt);
		print("event");
		if (evnt == "close"){
			gameObject.SetActive(false);
		}
		if (evnt == "open"){
			this.checkpassword();
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
