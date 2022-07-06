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
    [SerializeField]
    //private int _hpMax = 10;
    
    //public int HPMax { get { return _hpMax; } private set { _hpMax = value; } }

    private int _stage;
    private int _award;
    private int _price;
    //public Text hpText;
    public Animator animator;
    // Start is called before the first frame update
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
    private void GetHit(int damage)
    {
        animator.Play("GetHit");
        _stage++;
        //_hpCur -= damage;
        print("stage: "+ _stage);
        if (_stage == 3)
           StartCoroutine(DestroyItem());
        else
            currentImg.sprite = images[_stage];
    }
    private IEnumerator DestroyItem()
    {
        animator.Play("Destroy");
        yield return new WaitForSeconds(0.5f);
        EventManager.Instance.ItemDestroyed();
        Destroy(this.gameObject);
        //_hpCur = _hpMax;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
