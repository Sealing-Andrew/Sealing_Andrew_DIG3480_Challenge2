using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
public class Life: MonoBehaviour 
{

    public TextMeshProUGUI countText;
	public GameObject LoseTextObject;
	public GameObject Player;
    private int count2;
    // Start is called before the first frame update
    void Start()
    {
        count2 = 3;
        SetcountText ();
		 LoseTextObject.SetActive(false);
	
    }

   
    void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		
		
		if (other.gameObject.CompareTag ("Enemy"))
		{
			other.gameObject.SetActive (false);

			// Add one to the score variable 'count'
			count2 = count2 - 1;

			// Run the 'SetCountText()' function (see below)
			SetcountText ();
		
		}
	}
    void SetcountText()
	{
		countText.text = "Lives: " + count2.ToString();
		
		if(count2 <= 0)
		{
		LoseTextObject.SetActive(true);
		}
		
	
	}
		
}
