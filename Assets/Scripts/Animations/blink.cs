using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{

	
	private string sNormal = "scifi_n";
	private string sHover = "scifi_h";
	private Sprite normal;
	private Sprite hover;
	private SpriteRenderer currSprite;

	private bool state;
	private float timer;

	public float delay;

    // Start is called before the first frame update
    void Start(){

		state = false;
		timer = Time.time;
		//load sprites
		normal = Resources.Load<Sprite>(sNormal);
		hover = Resources.Load<Sprite>(sHover);
		currSprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timer > delay){
			if (state){
				currSprite.sprite = normal;
			}
			else{
				currSprite.sprite = hover;
			}
			state = !state;
		timer = Time.time;
		}

    }
}
