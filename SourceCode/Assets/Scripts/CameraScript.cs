using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Offset;

	void Start ()
	{
	    Offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
	    transform.position = Player.transform.position + Offset;
	}
}
