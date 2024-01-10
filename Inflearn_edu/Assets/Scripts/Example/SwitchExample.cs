using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    /*
        switch(조건)
        {
            case 값1 :
                조건이 값1과 같을 때 실행할 코드
            break;
            case 값2 :
                조건이 값2와 같을 때 실행할 코드
            break;
            case 값3 : 
                조건이 값3과 같을 때 실행할 코드
            break;
            default : 
                값1,2,3 이 아닐때 실행할 코드
            break;
        }
    */

    void Start()
    {
        int number = 1;
        
        switch(number)
        {
            case 1:
            Debug.Log("값이 1입니다.");
            break;

            case 2:
            Debug.Log("값이 2입니다.");
            break;

            case 5:
            Debug.Log("값이 5입니다.");
            break;

            default:
            Debug.Log("값이 1도 2도 5도 아닙니다.");
            break;

        }

        // if문으로 변환 해보기
        if(number == 1)
        {
            Debug.Log("값이 1입니다");
        }
        else if(number == 2)
        {
            Debug.Log("값이 2입니다");
        }
        else if(number == 5)
        {
            Debug.Log("값이 5입니다.");
        }
        else
        {
            Debug.Log("값이 1도 2도 5도 아닙니다.");
        }
    } 
}
