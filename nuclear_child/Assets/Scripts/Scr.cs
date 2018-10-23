using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr : MonoBehaviour
{

    public GameObject[] weapon;
    private GameObject current;
    int current_weapon = 2;
    public float weaponCD = 0.3f;
    public float reload = 0.0f;
    public List<KeyCode> shootBtn;
    public float speed = 1;
    public Transform to;
    public float speed_move = 0.1f;

    // Use this for initialization
    void Start()
    {
        current = (GameObject)Instantiate(weapon[0], new Vector3(this.transform.position.x + 0.9f, this.transform.position.y, 0), this.transform.rotation);
        int current_weapon = 2;
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();

        foreach (KeyCode element in shootBtn)
        {
            if (Input.GetKey(element) && reload < 0)
            {
                reload = weaponCD;
                CmdShoot();
                break;
            }
        }
        if (reload >= 0)
            reload -= Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.F))
        {
            switch (current_weapon)
            {
                case 1:
                    Destroy(current);
                    current = (GameObject)Instantiate(weapon[0], current.transform.position, current.transform.rotation);
                    current_weapon++;
                    break;
                case 2:
                    Destroy(current);
                    current = (GameObject)Instantiate(weapon[1], current.transform.position, current.transform.rotation);
                    current_weapon++;
                    break;
                case 3:
                    Destroy(current);
                    current = (GameObject)Instantiate(weapon[2], current.transform.position, current.transform.rotation);
                    current_weapon = 1;
                    break;
            }
        }

    }

    void CmdShoot()
    {
        current.GetComponent<Weapon>().Shoot();
    }


    void PlayerMovement()
    {

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x - speed_move, this.transform.position.y);
            if (current.activeInHierarchy)
                current.transform.position = new Vector3(current.transform.position.x - speed_move, current.transform.position.y );
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x + speed_move, this.transform.position.y);
            if (current.activeInHierarchy)
                current.transform.position = new Vector3(current.transform.position.x + speed_move, current.transform.position.y);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + speed_move);
            if (current.activeInHierarchy)
                current.transform.position = new Vector3(current.transform.position.x, current.transform.position.y + speed_move);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speed_move);
            if (current.activeInHierarchy)
                current.transform.position = new Vector3(current.transform.position.x, current.transform.position.y - speed_move);

        }



        Vector3 mouse = Input.mousePosition; //гет мышь
          mouse = Camera.main.ScreenToWorldPoint(mouse);// перевод координат                                                    
        //this.transform.Rotate(0, 0, Mathf.Atan2(mouse.x, mouse.y));//функция позволяет вращать инстантно
        float angle = Mathf.Atan2(mouse.y - this.transform.position.y, mouse.x - this.transform.position.x) * Mathf.Rad2Deg  -90;
        float rot_angle = angle - this.transform.rotation.eulerAngles.z;
        //print("angle");
       // print(angle);
       // print("rot_angle");
       // print(this.transform.rotation.eulerAngles.z);
        //print("end");
        if (rot_angle != 0)
        {

            //this.transform.RotateAround(this.transform.position, Vector3.back, rot_angle);
            //this.transform.rotation = Quaternion.Euler(0, 0, angle);
            this.transform.RotateAround(this.transform.position, Vector3.back, -rot_angle);

            if (current.activeInHierarchy)
            {
                //current.transform.RotateAround(this.transform.position, Vector3.up, angle);
                current.transform.RotateAround(this.transform.position, Vector3.back, -rot_angle);


            }
        }
    }
    


    }
