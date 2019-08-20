using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
	private Color alpha;
	public float max;
	public float min;
	private int counter;
	private float sleep;
	private float timer;
	private float increment;
	private bool timing = false;
	private bool goingUp = false;


    // Start is called before the first frame update
    void Start()
    {
		alpha = this.GetComponent<SpriteRenderer>().color;
		sleep = 0.005f;
		increment = .01f;
		timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
			if (Time.time - timer > sleep){
				timer = Time.time;
				if (goingUp){
					alpha.a += increment;
				}
				else{
					alpha.a -= increment;
				}
				if (alpha.a <= min){
					goingUp = true;
				}
				else if (alpha.a >= max){
					goingUp = false;
				}
			this.GetComponent<SpriteRenderer>().color = alpha;
			}
		}
  }
