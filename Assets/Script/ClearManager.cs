using UnityEngine;
using System.Collections;

public class ClearManager : MonoBehaviour
{

	bool pause = true;
	[SerializeField]
	int waitTime = 3;
	
	IEnumerator Start ()
	{
		yield return new WaitForSeconds(waitTime);
		
		pause = false;
	}
	
	void Update ()
	{
		
		if (pause)
			return;
		
		if (Input.GetButtonDown ("Fire1"))
			Application.LoadLevel ("Title");
	}
}
