using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCounter : MonoBehaviour
{
    public  static int count;
    public Text countText;
    public Text winText;

    public int gool = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 5)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "star")
        {
            count += 1;
            SetCountText();
            Destroy(collision.gameObject);
        }
    }
    void SetCountText()
    {
        countText.text = count.ToString();
        if (count >= gool)
        {
            winText.text = "You Win!";
        }
    }
}
