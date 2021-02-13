using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiki_ : MonoBehaviour
{
    private Vector3 rotat_L = new Vector3(0, 0, 90f);
    private Vector3 rotat_R = new Vector3(0, 0, -90f);
    private Vector3 rotat_B = new Vector3(0, 0, -180f);

    bool migi;
    bool hidari;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        migi = false;
        hidari = false;
        /*Invoke("hidarisenkai",3f);
        Invoke("hidarisenkai",7f);*/
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(0, 0.01f, 0);
        if (hidari == true)//左旋回
        {
            this.transform.Translate(0.001f, 0, 0);
            this.transform.Rotate(rotat_L);
            this.hidari = false;
        }
        else if (migi == true)//右旋回
        {
            this.transform.Translate(-0.001f, 0, 0);
            this.transform.Rotate(rotat_R);
            this.migi = false;
        }
        else
        {
            this.transform.Translate(0, 0.001f, 0);
        }
        
    }
    void migisenkai()
    {
        this.migi = true;
    }
    void hidarisenkai()
    {
        this.hidari = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stage")
        {
            migisenkai();
        }
        else if (collision.gameObject.tag == "curve")
        {
            migisenkai();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "woll")
        {
            Destroy(gameObject);
        }
    }
}
