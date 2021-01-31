using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int x = 5;
    public int y = 5;
    public int tileSZ = 1;
    public GameObject[,] grid;
    public int numDiamonds = 5;
    public GameObject hiddenGround;
    public GameObject diamondGround;
    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();
        SetDiamonds();
    }
    void GenerateLevel()
	{
        grid = new GameObject[x, y];

       
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                grid[i, j] = Instantiate(hiddenGround, transform);
                int posX = i * tileSZ;
                int posY = j * tileSZ;
                grid[i, j].transform.position = new Vector2(posX, posY);
                grid[i, j].gameObject.tag = "Ground";
            }
        }
  
    }
    void SetDiamonds()
	{
        for (int i = 0;i < numDiamonds;i++)
		{
            int randX = Random.Range(0, x - 1);
            int randY = Random.Range(0, y - 1);

            grid[randX, randY].gameObject.tag = "Diamond";

		}

        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
