using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QiestItem : MonoBehaviour
{
    Transform player;
    float discance = 5f;
    Player p;
    public GameObject itemSlot;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player").transform;
        this.p = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < discance
            && Input.GetMouseButtonDown(0))
        {
            this.itemSlot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            //Destroy(this.gameObject);
        }
    }
}
