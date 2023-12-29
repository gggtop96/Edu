using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 변수 : 값을 담는 그릇
    // 자료형 : 그 그릇의 모양

    // 변수의 선언 -> 자료형 식별자;
    // 변수의 초기화 -> 자료형 식별자 = 값;
    int a;

    void Start()
    {
        a = 1;
        Debug.Log(a);
    }
}
