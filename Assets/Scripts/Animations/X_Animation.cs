using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Animation : MonoBehaviour
{

	public string id;
	//sprites
	private string smNormal = "MiddleClose_normal";
	private string smHover = "MiddleClose_hover";
	private string smClick = "MiddleClose_click";
	private string slNormal = "LargeClose_normal";
	private string slHover = "LargeClose_hover";
	private string slClick = "LargeClose_click";
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
		if (id == "large"){
				normal = Resources.Load<Sprite>(slNormal);
				hover = Resources.Load<Sprite>(slHover);
				click = Resources.Load<Sprite>(slClick);
		}
		else{
				normal = Resources.Load<Sprite>(smNormal);
				hover = Resources.Load<Sprite>(smHover);
				click = Resources.Load<Sprite>(smClick);
		}
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
