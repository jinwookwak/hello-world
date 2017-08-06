using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aispawner : MonoBehaviour
{
    public GameObject player;
    public GameObject ai;
    float maxX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float playerX = player.transform.position.x;
        if(playerX+5>=maxX)
        {
            for(int i = 0;i<4;i++)
            {
                Vector3 enemyposition = new Vector3();
                enemyposition.x = Random.Range(maxX, maxX + 5);
                enemyposition.y = Random.Range(-1, 1);

                GameObject enemy = Instantiate(ai);

                enemy.transform.position = enemyposition;
            }
            maxX += 5;
        }
	}
}
