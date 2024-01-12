using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeConversionExample : MonoBehaviour
{
    // 형변환
    // 1. 암시적(implicit) 형변환
    // ex. int -> long
    // 2. 명시적(emplicit) 형변환
    // ex. long -> int

    int a = 1;
    long b = 10000000000000;

    void Start()
    {
        // b = a; // 암시적 형변환
        // Debug.Log(b);

        a = (int)b; // 명시적 형변환. ()-> 형변환 연산자, 캐스팅 연산자
        Debug.Log(a);
    }
}
