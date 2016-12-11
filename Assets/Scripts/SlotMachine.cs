using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour {

    public GameObject left;
    public GameObject center;
    public GameObject right;
    bool spinning = false;
    float spinStart;
    int[] goodResult;
    int[] badResult;
    int[] result;


	// Use this for initialization
	void Start () {
        left.GetComponent<Animator>().SetInteger("status", 3);
        center.GetComponent<Animator>().SetInteger("status", 2);
        right.GetComponent<Animator>().SetInteger("status", 1);

        goodResult = new int[3] { 1, 1, 1 };
        badResult = new int[3] { 2, 2, 3 };
    }
	
	// Update is called once per frame
	void Update () {
        if (spinning == true)
        {
            updateSpin();
        }
	    
	}

    public void startSpin()
    {
        if (spinning == false)
        {
            spinning = true;
            spinStart = Time.time;
            left.GetComponent<Animator>().SetInteger("status", 0);
            center.GetComponent<Animator>().SetInteger("status", 0);
            right.GetComponent<Animator>().SetInteger("status", 0);

            if (Random.value > 0.5)
            {
                result = goodResult;
            } else
            {
                result = badResult;
            }
        }
    }

    void updateSpin()
    {
        if (Time.time - spinStart > 3)
        {
            left.GetComponent<Animator>().SetInteger("status", result[0]);
        }
        if (Time.time - spinStart > 4)
        {
            center.GetComponent<Animator>().SetInteger("status", result[1]);
        }
        if (Time.time - spinStart > 5)
        {
            right.GetComponent<Animator>().SetInteger("status", result[2]);
            spinning = false;
        }
    }
}
