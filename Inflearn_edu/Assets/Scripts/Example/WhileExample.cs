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

   void Start()
   {
    // 0부터 9까지 출력
    int i = 0;

    while(i < 10)
    {
        Debug.Log(i);
        i++;
    }

    for(int j = 0; j < 10; j++)
        {
            Debug.Log(j);
        }
   }
}
