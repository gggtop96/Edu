using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 배열 선언
    // 자료형 [] 식별자 = new 자료형[배열의 크기];
    // 배열의 크기 = 배열 요소의 갯수

    int score1 = 100;
    int score2 = 200;
    int score3 = 300;

    int [] scores = new int [3]; // [0,0,0]

    // 배열 초기화
    // 1. 자료형[] 식별자 = new 자료형[(배열의 크기)] {값1, 값2, 값3...};
    // 2. 자료형[] 식별자 = {값1, 값2, 값3...};
    int[] scores2 = new int[]{100, 200, 300}; // [100, 200, 300]
    int[] scores3 = {100, 200, 300}; // [100,200,300]

    // 배열의 사용
    // 1. 배열 요소 읽기
    // -> 배열의_이름[index]
    // *** index는 0부터 시작. ***
    // 2. 배열 요소 값 대입
    // -> 배열의_이름[index] = 값;
    void Start()
    {
        // 배열 요소 읽기
        Debug.Log(scores3[0]);
        Debug.Log(scores3[1]);
        Debug.Log(scores3[2]);

        // 배열 요소에 새로운 값 대입
        scores3 [1] = 50; // scores -> [100, 50, 300]
         Debug.Log(scores3[1]);
    }
}
