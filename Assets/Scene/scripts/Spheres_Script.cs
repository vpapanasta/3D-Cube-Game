using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Spheres_Script : MonoBehaviour {
	
	public GameObject spherePrefab;
	List<GameObject> spherelist;
	public int cc = 0;
	
	void Start()
	{
		spherelist = new List<GameObject> ();
	}
	
	void Update () 
	{
		// Add Sphere
		if (Input.GetKeyDown (KeyCode.Equals)) 
		{
			Vector3 pose = new Vector3(Random.Range(-1.0f,1.0f),Random.Range(0,2.0f),Random.Range(-1.0f,1.0f));
			//GameObject thisObject = (GameObject)Instantiate(spherePrefab,pose,new Quaternion(0, 0, 0, 0));
			spherelist.Add((GameObject)Instantiate(spherePrefab,pose,new Quaternion(0, 0, 0, 0)));
			spherelist[spherelist.Count-1].GetComponent<Renderer>().material.color = 
				new Color(Random.Range(0,1.0f), Random.Range(0,1.0f), Random.Range(0,1.0f));

		}
		if(Input.GetKeyDown (KeyCode.Minus))
		{
			if(spherelist.Count != 0)
			{
				Destroy(spherelist[cc]);
				spherelist.Remove(spherelist[cc]);

			}
		}

		if(Input.GetKeyDown(KeyCode.Q))
		{
			Application.Quit();
		}
	}
}