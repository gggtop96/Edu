using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    /*
    for(초기화;조건식;반복자)
    {
        반복할 코드
    }
    */

    void Start()
    {
        // 0부터 9까지 출력하는 코드
        // i => 카운터 변수
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
        
        // 0부터 10까지 숫자 중 짝수만 출력하라.
        for(int i = 0; i <= 10; i += 2)
        {
            Debug.Log(i);
        }
    }
}
