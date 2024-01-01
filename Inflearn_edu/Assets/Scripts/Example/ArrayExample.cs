using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arro : MonoBehaviour
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

}
