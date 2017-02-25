using UnityEngine;

public class RotatingCube : MonoBehaviour {

	void Start () {
		
	}
	
	void Update ()
	{
	    transform.Rotate(new Vector3(15, 30, 34)*Time.deltaTime);
	}
}
