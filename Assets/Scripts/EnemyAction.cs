using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    float timer;

    float interval = 4;

    public GameObject fireBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	timer += Time.deltaTime;

	if(timer >= interval)
	{
		timer = 0;

		Instantiate(fireBall, this.gameObject.transform.position, Quaternion.identity);
	}
    }
}
