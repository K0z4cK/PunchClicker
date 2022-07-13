using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //private int _damage;
    private int _price;
    [SerializeField]
    private string _side; 
    [SerializeField]
    private Transform weapon;
    [SerializeField]
    Animator _animation = new Animator();

    /* void Attack()
     {
         //animation
         print("item hit by: " + _damage);
         _animations[curAnim].Play("Kick");
         curAnim -= 1;
         if(curAnim < 0)
             curAnim = _animations.Count - 1;
         EventManager.Instance.ItemAttack(_damage);

     }*/
    void Attack()
    {
        print("item hit");
        _animation.Play("Hit");
        EventManager.Instance.ItemAttack();
    }
    void Awake()
    {
        weapon = GetComponent<Transform>();
        //_damage = 10; //temp
        switch (_side)
        {
            case "left":
                EventManager.Instance.leftClick.AddListener(Attack);
                break;
            case "right":
                EventManager.Instance.rightClick.AddListener(Attack);
                break;
            default:
                break;
        }

    }
}
