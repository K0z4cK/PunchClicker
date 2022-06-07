using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int _hp;
    private int _award;
    private int _price;
    // Start is called before the first frame update
    void Awake()
    {
        _hp = 100;
        EventManager.Instance.attackItem.AddListener(GetHit);
    }
    private void OnMouseDown()
    {
        print("Item click");
        EventManager.Instance.ItemClicked();
        
    }
    private void GetHit(int damage)
    {
        _hp -= damage;
        print("item hp: "+ _hp);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
