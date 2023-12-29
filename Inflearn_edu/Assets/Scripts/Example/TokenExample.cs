using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenExample : MonoBehaviour
{
    // 나는 너를 사랑한다.
    // 1. 자모음 -> ㄴ, ㅏ, ㅡ, ㄹ ...
    // 2. 단어 -> 나, 는, 너, 를, 사랑, 한다
    // 3. 문장 -> 나는 너를 사랑한다.

    // Token : 문법적으로 더 이상 나누어질 수 없는 요소
    // 종류
    // 1. 예약어 (키워드) : C#에서 미리 정의해둔 토큰
    // 2. 식별자 : 이름
    // 3. 리터럴 : 값
    // 4. 연산자 : 연산을 하기 위한 토큰. +, -, *, /
    // 5. 구분자 : 특정 요소를 문법적으로 구분하기 위한 토큰

    int a = 1;
    // int → 예약어(키워드)
    // a → 식별자
    // = → 연산자
    // 1 → 리터럴
    // ; → 구분자
    
}
