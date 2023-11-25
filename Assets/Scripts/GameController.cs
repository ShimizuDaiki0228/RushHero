using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int count;

    public GameObject clearText;
    public GameObject unko;

    public bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if(isPlaying == false)
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("Main");
		}
	}
    }

    public void Count()
    {
	count++;
	//Debug.Log(count);
	if(count >= 4)
	{
		Clear();
	}
    }

    public void Clear()
    {
	clearText.SetActive(true); 
	isPlaying = false;
    }
}
