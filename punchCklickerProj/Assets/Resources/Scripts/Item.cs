using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField]
    public Image currentImg;
    [SerializeField]
    public List<Sprite> images = new List<Sprite>();
    
    private int _stage;
    private int _award;
    private int _price;
    public Animator animator;
    void Awake()
    {
        //_hpMax = 100;
        _stage = 0;
        currentImg.sprite = images[_stage];       
        EventManager.Instance.attackItem.AddListener(GetHit);
    }
    /*private void OnMouseDown()
    {
        print("Item click");
        EventManager.Instance.ItemClicked();
        
    }*/
    private void GetHit()
    {
        animator.Play("GetHit");
        _stage++;
        print("stage: "+ _stage);
        if (_stage == 3)
           StartCoroutine(DestroyItem());
        else
            currentImg.sprite = images[_stage];
    }
    private IEnumerator DestroyItem()
    {
        EventManager.Instance.attackItem.RemoveListener(GetHit);
        EventManager.Instance.ScoreUpdated();
        animator.Play("Destroy");
        yield return new WaitForSeconds(0.5f);
        EventManager.Instance.ItemDestroyed();
        
        Destroy(this.gameObject);
    }

}
