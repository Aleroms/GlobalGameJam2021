using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	LevelGenerator grid;

	private void Start()
	{
		grid = GameObject.Find("Grid").GetComponent<LevelGenerator>();

	}
	public void Digging(string found,Transform pos)
	{
		int i = grid.GetPositionX(pos);
		int j = grid.GetPositionY(pos);

        if(found == "Ground")
		{
            //Debug.Log("Ground tag received");
			grid.UnEarth("Ground",i,j);
		}
        if(found == "Diamond")
		{
           // Debug.Log("Diamond tag received");
			grid.UnEarth("Diamond",i,j);
		}
	}


}
