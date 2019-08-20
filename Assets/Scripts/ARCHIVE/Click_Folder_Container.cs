using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class Click_Folder_Container : MonoBehaviour
{
    // initial
    public bool selected;
    private Click_Folder_Container otherSelect;
    private SpriteRenderer[] composite;
	private MeshRenderer text;
    private Vector3 screenPoint;
    private Vector3 offset;
	
	private int increment = 4;

    void Start()
    {
        selected = false;
        composite = this.GetComponentsInChildren<SpriteRenderer>();
		text = this.GetComponentInChildren<MeshRenderer>();
		text.sortingOrder = 1;
    }

    /*
     *
     *	fXn :: changeLayer
     *		@param command :: {"foreground", "background"}
     *
     *	switches window from background into foreground.
     *
     *
     */
    public void changeSelection()
    {
        if (selected == true)
        {
            foreach (SpriteRenderer component in composite)
            {
				if (component.sortingOrder < 4){
                	component.sortingOrder += increment; //random value to make sure it is on top layer
				}
            }
			if (text.sortingOrder < 4){
				text.sortingOrder += increment;
			}
        }
        else if (selected == false)
        {
            foreach (SpriteRenderer component in composite)
            {
				if (component.sortingOrder > 1){
                	component.sortingOrder -= increment; // random value to make sure it is on top layer
				}
			}
			if (text.sortingOrder > 1){
				text.sortingOrder -= increment;
			}
        }
    }

	private void select(){
		
		if (selected == false){
	    	selected = true;
			//changeSelection();
		}
	}

	private void drag(){
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

	}

    //set Active when pressed
    void OnMouseDown(){
		select();
		drag();
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    //update method
    void Update()
    {

    }
}
