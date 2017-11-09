using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look atx
    //public AudioSource audio;

    void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}

        
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		// change the target of the LookAtTarget script to be this gameobject.
        mutaTudo();
        LookAtTarget.target = target;
        GameObject.Find(this.name).GetComponent<AudioSource>().enabled = true;
        Camera.main.fieldOfView = 60 * target.transform.localScale.x;
        
    }

    void mutaTudo()
    {
        GameObject[] planetas = GameObject.FindGameObjectsWithTag("planetas");

        for (int i=0; i < planetas.Length; i++)
            planetas[i].GetComponent<AudioSource>().enabled = false;
    }
}
