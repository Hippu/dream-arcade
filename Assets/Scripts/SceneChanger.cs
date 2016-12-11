using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadBedRoom ()
    {
        SceneManager.LoadScene("Bed Room");
    }
    public void loadSlotMachine ()
    {
        SceneManager.LoadScene("Slot game");
    }
    public void loadMain ()
    {
        SceneManager.LoadScene("main");
    }
}
