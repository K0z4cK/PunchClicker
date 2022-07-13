using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    List<Item> items = new List<Item>();
    void Awake()
    {
        CreateItem();
        EventManager.Instance.itemDestroy.AddListener(CreateItem);
    }
    void CreateItem()
    {
       var item = items[Random.Range(0, items.Count)];
       Instantiate(item, this.transform);
       EventManager.Instance.ItemCreated();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
