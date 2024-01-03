using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorExample : MonoBehaviour
{
    // 1. 산술 연산자
    // +, -, *, /, %, ++, --

    // 2. 대입 연산자
    // = , 산술연산자와 결합
    // 3. 논리 연산자
    // &&(and), ||(or), !(not)
    // 4. 비교 연산자
    // >, <, <=, >=, ==(같다) -> 결과 값이 bool(true, false)

    void Start()
    {
        int a = 10;
        int b = 2;
        // 산술
        Debug.Log(a + b); // 12
        Debug.Log(a - b); // 8
        Debug.Log(a * b); // 20
        Debug.Log(a / b); // 5

        Debug.Log(a % b); // 0
        Debug.Log(10 % 3); // 1

        a++;
        b--;
        Debug.Log(a); // 11
        Debug.Log(b); // 1

        //대입
        a = b;
        Debug.Log(a); // 1
        a += 3; // a = a + 3;

        // 논리
        bool t = true;
        bool f = false;
        Debug.Log(t && f); // false
        Debug.Log(t || f); // true
        Debug.Log(!t); // false

        // 비교
        // a = 4, b = 1
        int c = 1;
        int d = 3;
        Debug.Log(c <= d); //true
        Debug.Log(c > d); //false
        Debug.Log(c == d); //false

        Debug.Log(!(c == b) || (d > a)); // false
    }
}
