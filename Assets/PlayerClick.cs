using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClick : MonoBehaviour
{
    GameManager gm;

	private void Start()
	{
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //print("debug");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.tag == "Ground")
            {
              //  Debug.Log("sending tag to GameManager: Ground");
                gm.Digging(hit.collider.tag,hit.collider.transform);
                //hit.collider.transform
                
            }
            if(hit.collider.tag == "Diamond")
			{
               // Debug.Log("sending tag to GameManager: Diamond");
                gm.Digging(hit.collider.tag,hit.collider.transform);
			}
        }
    }
}
