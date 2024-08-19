using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//한글

public class Item : MonoBehaviour
{
    //맴버 변수 정의
    public string itmeName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;
    

    private void Awake()//이벤트 함수 이미 유니티가 정해놓은 함수를 말함, start나 update 같은 것
    {

        Debug.Log("Awake매서드 호출됨!");
        //공격력 : 0
        Debug.Log($"공격력 : {this.damage}");
        Debug.Log($"이름 : {this.itmeName}");
        Debug.Log($"공격 속도 : {this.attackSpeed}");
        Debug.Log($"내구도 : {this.isBroken}");
        Debug.LogFormat("공격력 : {0}",  this.damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start매서드 호출됨");
    }

    // Update is called once per frame
    void Update()
    {
        //컨트롤 +k+c 주석으로 바꾸기
        //컨트롤 +k+u 주석 해제
        Debug.Log("Update매서드 호출됨");
    }
}
