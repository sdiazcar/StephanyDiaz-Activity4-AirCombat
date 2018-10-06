using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightControl : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detectada");

        GameObject enemy = collision.collider.gameObject;


        GameObject missile = this.gameObject;

        GameObject.Destroy(enemy);
        GameObject.Destroy(missile);
        {
        }
    }
}

