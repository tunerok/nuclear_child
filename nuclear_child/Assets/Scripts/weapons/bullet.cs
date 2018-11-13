using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public Transform boom;

    // Как долго существует лазер
    public float lifetime = 20000.0f;

    // Как быстро движется лазер
    public float speed = 30.0f;

    // Как много наносит урона лазер при соприкосновении с врагами
    public int damage = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = transform.position + transform.right* Time.deltaTime * speed;
        if (this.transform.position.x < -8.5 || this.transform.position.x > 9.0f || this.transform.position.y > 9.0f || this.transform.position.y < -9.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
