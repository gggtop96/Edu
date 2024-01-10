using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileExample : MonoBehaviour
{
   /*
   While(조건)
   {
    반복할 내용
   }
   */

    // 1. break -> 현재 실행하고 있는 문을 빠져나가라.
    // 2. continue -> 다음 반복으로 넘어가라.

   void Start()
   {
    // 0부터 9까지 출력
    // int i = 0;
    // 
    // while(true)
    // {
    //     if(i >= 10)
    //     {
    //         break;
    //     }
    //     Debug.Log(i);
    //     i++;
    // }

    //  짝수만 출력해라 (continue 이용)
    // int j = 0;
    // 
    // while(j < 10)
    // {
    //     if(j % 2 == 1) // 홀수
    //     {
    //         j++;
    //         continue;
    //     }
    //     Debug.Log(j);
    //     j++;
    // }

    // 1부터 100까지의 숫자 중 3의 배수만 출력해라
    for (int k = 1; k <=100; k++)
    {
        if( k > 50)
        {
            break;
        }

        if (k % 3 == 0)
        {
            Debug.Log(k);
        }
        
    }


    
   }
   
}
