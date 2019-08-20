using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityPassword : MonoBehaviour
{

	public string password;
	string userInput;
	KeyCode prevE;

	// Start is called before the first frame update
    void Start()
    {
		prevE = KeyCode.None;
    }

	void OnGUI(){
		Event e = Event.current;
		if (e.keyCode != prevE){
			if (e.keyCode != KeyCode.None){
				if(e.keyCode != KeyCode.Return){
					userInput += e.keyCode;
					prevE = e.keyCode;
					print(userInput);
				}
				else{
					checkPassword();
				}
			}

		}
	}

	void checkPassword(){
		if (userInput == password){
			print("is this application quiting");
			Application.Quit();
		}
		else{
			userInput = "";
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
