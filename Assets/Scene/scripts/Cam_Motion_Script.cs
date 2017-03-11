using UnityEngine;
using System.Collections;

public class Cam_Motion_Script : MonoBehaviour {
	
		public float speed = 1.0f; // Init Camera speed
		public Transform target;
		public float step = 2f; // Init step 

		// Update is called once per frame
		void LateUpdate()
		{	
			// Right Direction
			if (Input.GetKeyDown(KeyCode.F))
			{
				Vector3 position = this.transform.position;
				position.x = position.x + step;
				this.transform.position = position;
			}
			// Left Direction
			if (Input.GetKeyDown(KeyCode.S))
			{
				Vector3 position = this.transform.position;
				position.x = position.x - step;
				this.transform.position = position;
			}
			// Up Direction
			if (Input.GetKeyDown(KeyCode.E))
			{
				Vector3 position = this.transform.position;
				position.y = position.y + step;
				this.transform.position = position;
			}
			// Down Direction
			if (Input.GetKeyDown(KeyCode.D))
			{
				Vector3 position = this.transform.position;
				position.y = position.y - step;
				this.transform.position = position;
			}
			// To axis start
			if (Input.GetKeyDown(KeyCode.H))
			{
				Vector3 position = this.transform.position;
				position.z = position.z + step;
				this.transform.position = position;
			}
			// Away from axis start
			if (Input.GetKeyDown(KeyCode.B))
			{
				Vector3 position = this.transform.position;
				position.z = position.z - step;
				this.transform.position = position;
			}
			// Initial Camera Position
			if (Input.GetKeyDown(KeyCode.O))
			{
				Vector3 position = this.transform.position;
				position.x =0;
				position.y = 1;
				position.z = -3;
				this.transform.position = position;
			}
			transform.LookAt(target);
		}


}