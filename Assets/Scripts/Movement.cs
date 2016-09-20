using UnityEngine;
using System.Collections;

public class Movement: MonoBehaviour {

	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {
		//move forward if I press W
		if (Input.GetKey (KeyCode.W)) { //forward

			transform.Translate (0f, 0f, 10f * Time.deltaTime); //translate always converts to local space

			//transform.position += new Vector3 (0f, 0f, 1f); //world space movement

			Camera.main.transform.position = transform.position + new Vector3 (-.16f, 6.03f, -7.34f); 
 
		}

		if (Input.GetKey (KeyCode.S)) { //backward

			transform.Translate (0f, 0f, -10f * Time.deltaTime); //translate always converts to local space

			//transform.position += new Vector3 (0f, 0f, 1f); //world space movement

			Camera.main.transform.position = transform.position + new Vector3 (-.16f, 6.03f, -7.34f); 
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.eulerAngles += new Vector3 (0f, -150f * Time.deltaTime, 0f); 
			//transform.rotation *= Quaternion.Euler(0f, -5f, 0f); another way to rotate using Quaternion math
			//transform.Rotate(0f,-5f,0f); //more intuitive way to turn left? 

			Camera.main.transform.position = transform.position + new Vector3 (-.16f, 6.03f, -7.34f); 
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.eulerAngles += new Vector3 (0f, 150f * Time.deltaTime, 0f); 
			//transform.rotation *= Quaternion.Euler(0f, -5f, 0f); another way to rotate using Quaternion math
			//transform.Rotate(0f,-5f,0f); //more intuitive way to turn left? 

			Camera.main.transform.position = transform.position + new Vector3 (-.16f, 6.03f, -7.34f);  

		}
	}
}
