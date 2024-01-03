using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfExample : MonoBehaviour
{
    // 제어문 (Control statment)
    // - 조건문(if, switch), 반복문(for, while, foreach)

    // if, else, else if
    /*
        if(조건식1)
        {
            조건식1이 참일 때 실행할 코드
        }
        else if (조건식2)
        {
            조건식 1은 거짓이고, 조건식 2는 참일 때 실행할 코드
        }
        else
        {
            조건식1과 조건식2가 거짓일 때 실행할 코드
        }
    */

    void Start()
    {
        float number = 3.0f;
        if(number > 4.0f)
        {
            Debug.Log("값이 4보다 큽니다.");
        }
        else if(number > 3.0f)
        {
            Debug.Log("값이 4보다 작거나 같고, 3보다 큽니다.");
        }
        else
        {
            Debug.Log("값이 3보다 작거나 같습니다.");
        }
    }

}
