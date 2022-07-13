using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterPanel : MonoBehaviour
{
    int _hpMax;
    int _hpCur;
    public Text hpText;
    private void ChangeHp(int newHP)
    {
        _hpCur -= newHP;
        ChangeText();
    }
    private void NewItem(int newHP)
    {
        _hpMax = newHP;
        _hpCur = newHP;
        ChangeText();

    }
    private void ChangeText()
    {
        hpText.text = (_hpCur + "/" + _hpMax);

    }
    void Awake()
    {
        //EventManager.Instance.itemCreate.AddListener(NewItem);
        //EventManager.Instance.attackItem.AddListener(ChangeHp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
