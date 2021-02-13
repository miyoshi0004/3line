using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jiki_idou : MonoBehaviour
{
    [SerializeField]
    private Sprite migimuki;
    [SerializeField]
    private Sprite hidaramuki;
    [SerializeField]
    private Sprite usiromuki;
    bool mae;
    bool usiro;
    bool migi;
    bool hidari;

    SpriteRenderer spriteRenderer;
    BoxCollider2D bc2d;

    [SerializeField] public GameObject p1;
    [SerializeField] public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        bc2d = this.gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        this.mae =false;
        this.usiro = false;
        this.migi = false;
        this.hidari = false;
       /* Invoke("hidarisenkai", 5f);
        Invoke("migisenkai", 3f);
        Invoke("tyokusinn",7f);
        Invoke("koutai",9f);
        */

    }

    // Update is called once per frame
    void Update()
    {


        //this.transform.Translate(0, 0.01f, 0);
        if(mae == true)//前進
        {
            this.transform.Translate(0,0.002f,0);
            this.spriteRenderer.sprite = usiromuki;
            this.bc2d.size = new Vector2(0.7f, 1.2f);
        }
        else if (hidari == true)//左旋回
        {
            this.transform.Translate(-0.002f, 0, 0);
            this.spriteRenderer.sprite  = hidaramuki; 
            this.bc2d.size = new Vector2(1.2f, 0.7f);

        }
        else if (migi == true)//右旋回
        {
            this.transform.Translate(0.002f, 0, 0);
            this.spriteRenderer.sprite = migimuki;
            this.bc2d.size = new Vector2(1.2f, 0.7f);

        }
        else if(usiro == true)//後退
        {
            this.transform.Translate(0, -0.002f, 0);
            this.spriteRenderer.sprite = usiromuki;
            this.bc2d.size = new Vector2(0.7f, 1.2f);
            
        }
        else
        {
            this.transform.Translate(0,0.002f,0);
            this.spriteRenderer.sprite = usiromuki;
            this.bc2d.size = new Vector2(0.7f, 1.2f);
        }

    }

    //以下は呼び出し

    void migisenkai()//右に曲がる
    {
        this.migi = true; this.mae = false; this.usiro = false; this.hidari = false; this.spriteRenderer.flipY = false;

    }
    void hidarisenkai()//左に曲がる
    {
        this.hidari = true; this.mae = false; this.usiro = false; this.migi = false; this.spriteRenderer.flipY = false;
    }
    void tyokusinn()//上に進む
    {
        this.mae = true; this.usiro = false; this.migi = false; this.hidari = false; this.spriteRenderer.flipY = false;
    }
    void koutai()//下に戻る
    {
        this.usiro = true; this.mae = false; this.migi = false; this.hidari = false; this.spriteRenderer.flipY = true;
    }

    
}
