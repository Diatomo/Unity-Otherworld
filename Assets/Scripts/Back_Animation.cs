using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Animation : MonoBehaviour{
	
	//sprites
	private string sNormal = "back_normal";
	private string sHover = "back_hover";
	private string sClick = "back_click";
	private Sprite normal;
	private Sprite hover;
	private Sprite click;
	private SpriteRenderer currSprite;

	//state variables
	bool stateHover = false;
	bool stateClick = false;

    // Start is called before the first frame update
    void Start(){
		//load sprites
		normal = Resources.Load<Sprite>(sNormal);
		hover = Resources.Load<Sprite>(sHover);
		click = Resources.Load<Sprite>(sClick);
		currSprite = this.GetComponent<SpriteRenderer>();
    }

	//INPUT HANDLERS
	void OnMouseOver(){
		stateHover = true;
	}

	void OnMouseDown(){
		stateClick = true;
	}

	void OnMouseUp(){
		stateClick = false;
	}

	/*
	 *
	 *	FxN :: updateButtonState
	 *
	 * 		Updates Sprites based on the state
	 * 			Priority goes to Click -> Hover -> Normal
	 *
	 */
	void updateButtonState(){
		if (stateClick == true && stateHover == true){
			currSprite.sprite = click;
		}
		else if (stateHover == true){
			currSprite.sprite = hover;
		}
		else{
			currSprite.sprite = normal;
		}
		stateHover = false;
	}


    // Update is called once per frame
    void Update()
    {
    	updateButtonState(); 
    }
}
