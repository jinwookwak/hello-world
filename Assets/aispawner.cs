using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aispawner : MonoBehaviour
{
    public GameObject player;
    public GameObject ai;
    public List <GameObject> background;
    float maxX;
    public float distance;
    public int spawncount;
    public float backgrounddistance;
    public int backgroundcount;
    public float yrange;
    public float aiyrange;
    float backgroundmax;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float playerX = player.transform.position.x;
        if(playerX+ 10 + distance >=maxX)
        {
            for(int i = 0;i<spawncount;i++)
            {
                Vector3 enemyposition = new Vector3();
                enemyposition.x = Random.Range(maxX, maxX +distance);
                enemyposition.y = Random.Range(-aiyrange, aiyrange);

                GameObject enemy = Instantiate(ai);

                enemy.transform.position = enemyposition;
            }
            maxX += distance;
        }
        
        if (playerX + 10 + backgrounddistance >= backgroundmax)
        {
            for (int i = 0; i < spawncount; i++)
            {
                Vector3 enemyposition = new Vector3();
                enemyposition.x = Random.Range(backgroundmax, backgroundmax + backgrounddistance);
                enemyposition.y = Random.Range(-yrange, yrange);

                GameObject enemy = Instantiate(background[Random.Range(0,background.Count)]);

                enemy.transform.position = enemyposition;
            }
            backgroundmax += backgrounddistance;
        }
    }
}
