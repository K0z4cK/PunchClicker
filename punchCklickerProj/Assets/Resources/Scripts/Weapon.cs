using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int _damage;
    private int _price;

    [SerializeField]
    private GameObject weapon;
    [SerializeField]
    List<Animator> _animations = new List<Animator>();
    private int curAnim;
    // List of animations

    void Attack()
    {
        //animation
        print("item hit by: " + _damage);
        _animations[curAnim].Play("Kick");
        curAnim -= 1;
        if(curAnim < 0)
            curAnim = _animations.Count - 1;
        EventManager.Instance.ItemAttack(_damage);
        
    }
    void Awake()
    {
        _damage = 10; //temp
        EventManager.Instance.itemClick.AddListener(Attack);
        curAnim = _animations.Count-1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
