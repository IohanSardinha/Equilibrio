using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Plataforma : MonoBehaviour {
	float time = 0;
    float realTime = 0;
    public Text tempo;
    public Text a;
    	
	// Update is called once per frame
	void FixedUpdate () {
		time += Time.deltaTime;
        realTime += Time.deltaTime;
        tempo.text = Mathf.Round(realTime).ToString();
        a.text = Mathf.Round(Input.acceleration.x*25).ToString();
        if (time >= 5) {
			transform.localScale -= new Vector3(transform.localScale.x*0.05f,0,0);
            time = 0;
		}
        if (Application.platform == RuntimePlatform.Android)
        {
            transform.eulerAngles = new Vector3(0, 0, Mathf.Round(-Input.acceleration.x * 100)*0.5f);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, 0, -50 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, 0, 50 * Time.deltaTime);
            }
        }
	}
}
