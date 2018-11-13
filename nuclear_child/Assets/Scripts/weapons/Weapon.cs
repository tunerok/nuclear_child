using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public GameObject [] bullets;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    void Reload()
    {

    }

    public void Shoot() {
      //  Quaternion q  = new Quaternion();
      //  q.eulerAngles.z; 
        var bullet = Instantiate(bullets[0], this.transform.position, Quaternion.Euler(this.transform.rotation.eulerAngles.x, this.transform.rotation.eulerAngles.y, this.transform.rotation.eulerAngles.z+90));

    }
}
