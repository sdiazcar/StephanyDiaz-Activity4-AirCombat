using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public float speed;

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.forward * speed);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");

            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/missile") as GameObject);

            GameObject ShootPivote = GameObject.Find("fighter/ShootPivote");

            newMissile.transform.SetParent(ShootPivote.transform);
            newMissile.transform.localPosition = Vector3.zero;
            newMissile.transform.SetParent(null);
        }
    }



}

