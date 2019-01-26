using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	public void OnButtPress ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnTitPress()
    {
        Application.Quit();
    }
	
	void Update () {
		
	}
}
