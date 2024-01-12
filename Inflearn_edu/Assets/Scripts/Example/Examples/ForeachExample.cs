using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachExample : MonoBehaviour
{
    
    /*
        foreach(변수의타입 변수식별자 in 배열의식별자)
        {
            반복할 내용
        }
    */
    
    /*
     1~5까지의 값을 가진 numbers라는 이름의 배열을 생성하고
     배열이 가진 값을 모두 볼 수 있게 하시오(for문 이용)
    */
    int [] numbers = {1, 2, 3, 4, 5};
    
    void Start()
    {
        /*
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);
        Debug.Log(numbers[3]);
        Debug.Log(numbers[4]);
        
        //for문
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(numbers[i]);
        }
        */

        foreach(int number in numbers)
        {
            Debug.Log(number);
        }


    }


}
