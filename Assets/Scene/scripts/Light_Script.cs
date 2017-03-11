using UnityEngine;
using System.Collections;

public class Light_Script : MonoBehaviour {

	// Initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	private bool light1;
	private bool light2;
	private bool light3;
	private bool light4;
	private int counter = 0;

	void Update () 
		{

				if (Input.GetKeyDown (KeyCode.F5)) 
				{
						foreach (Transform child in transform) 
						{
						if (child.name == "Spotlight_Up") 
								{
									light1 = !light1;
									child.gameObject.SetActive (light1);
								}
						}
				}
				if (Input.GetKeyDown (KeyCode.F6)) 
				{
						foreach (Transform child in transform) 
						{
						if (child.name == "Spotlight_Down") 
								{
									light2 = !light2;
									child.gameObject.SetActive (light2);
								}
						}
				}
				if (Input.GetKeyDown (KeyCode.F7)) 
				{
						foreach (Transform child in transform) 
						{
							if (child.name == "Directional light") 
							{
								light3 = !light3;
								child.gameObject.SetActive (light3);
							}
						}
				}
				if (Input.GetKeyDown (KeyCode.F8)) 
				{
						foreach (Transform child in transform) 
						{
							if (child.name == "Point light") 
							{
								light4 = !light4;
								child.gameObject.SetActive (light4);
							}
						}
				}
				if (Input.GetKeyDown (KeyCode.P)) 
				{
						foreach (Transform child in transform) 
						{
							if (child.name == "Point light") 
							{
								

								if (counter%8 == 0){
									child.transform.position = new Vector3(0.866f, 1.936f, -0.989f);
								}
								if (counter%8 == 1){
									child.transform.position = new Vector3(0.866f, 1.936f, 0.989f);
								}
								if (counter%8 == 2){
									child.transform.position = new Vector3(-0.866f, 1.936f, -0.989f);
								}
								if (counter%8 == 3){
									child.transform.position = new Vector3(-0.866f, 1.936f, 0.989f);
								}
								if (counter%8 == 4){
									child.transform.position = new Vector3(0.866f, 0, -0.989f);
								}
								if (counter%8 == 5){
									child.transform.position = new Vector3(0.866f, 0, 0.989f);
								}
								if (counter%8 == 6){
									child.transform.position = new Vector3(-0.866f, 0, -0.989f);
								}
								if (counter%8 == 7){
									child.transform.position = new Vector3(-0.866f, 0, 0.989f);
								}
							}
						}
					counter = counter + 1;
				}
				if (Input.GetKeyDown (KeyCode.F9)) 
				{
					foreach (Transform child in transform) 
					{
						if (child.name == "Directional light") 
						{
							child.gameObject.GetComponent<Light>().shadows = LightShadows.None;
						}
					}
				}
				if (Input.GetKeyDown (KeyCode.F10)) 
				{
					foreach (Transform child in transform) 
					{
						if (child.name == "Directional light") 
						{
							child.gameObject.GetComponent<Light>().shadows = LightShadows.Soft;
						}
					}
				}

}
}
