using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonShow : MonoBehaviour {

    public Button button;

	// Use this for initialization
	void Start () {
        button.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            button.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            button.gameObject.SetActive(false);
        }
    }
}
