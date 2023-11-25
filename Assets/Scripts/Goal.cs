using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goalText; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
      if(other.gameObject.tag == "Player")
      {
 	goalText.SetActive(true);
      }	
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" )
        {
            goalText.SetActive(false);
        }
    }

/*
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
      {
 	goalText.SetActive(false);
      }	
    }

    
*/
}
