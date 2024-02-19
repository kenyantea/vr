using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        a = Random.Range(0, 255);
    //        b = Random.Range(0, 255);
    //        c = Random.Range(0, 255);
    //        this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);
    //    }
    //}
    //private void OnMouseDown() //отжатие мышки
    //{
    //    this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    //}

    //private void OnMouseUp() //нажатие мышки
    //{
    //    this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    //}

    //private void OnMouseEnter() //мышка войдет в поле зрения куба
    //{
    //    capsule.gameObject.GetComponent<Renderer>().material.color = Color.red;
    //}

    //private void OnMouseExit() 
    //{
    //    capsule.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    //}

    void FixedUpdate()
    {
       
    }

    public void ChangeColor()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte) a, (byte) b, (byte) c, 1);
        capsule.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)(255 - a), (byte)(255 - b), (byte)(255 - c), 1);
    }
}
