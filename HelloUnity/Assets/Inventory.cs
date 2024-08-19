using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//한글

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {
        //itemGos를 순회 하면서 아이템들의 이름을 추력하고 싶다
        Debug.Log($"<color=yellow>{itemGos.Count}</color>");//색깔 입히기
        //장검
        //단검
        //활

        for (int i = 0; i < this.itemGos.Count; i++)
        {
            //해당 인덱스에 해당하는 요소의 값 출력
            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"{item.itmeName}");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
