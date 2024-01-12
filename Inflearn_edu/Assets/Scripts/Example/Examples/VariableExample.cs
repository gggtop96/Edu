using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 변수 : 값을 담는 그릇
    // 자료형 : 그 그릇의 모양

    // 변수의 선언 -> 자료형 식별자;
    // 변수의 초기화 -> 자료형 식별자 = 값;
    int a;

    // 자료형의 종류
    // 1. 정수형 - int, long, byte
    // 2. 실수형 - float, double
    // 3. 문자형 - char, string
    // 4. 논리형 - bool
    // 5. object

    float f = 1.7f;
    // float f = 1.7; 은 가능할까?
    // 원래라면 가능해야 하지만 C#에서는 실수를 무조건 double로 처리를 하기에
    // float은 리터럴(값)에 f를 붙여서 float이라는 형태라고 명시를 해줘야함

    double d = 1.7;
    // 위에서 언급한 것처럼 C#에서는 실수를 무조건 double로 처리하기에
    // 리터럴(값)에 d를 붙이지 않아도 인식함

    char c = 'c';

    string b = "hello";
    // long b = 'H'; 가 성립할까?
    // 일단 성립한다. 왜냐하면 문장이 아닌 한글자는 정수로 형변환이 되기 때문

    bool t = true;
    // bool 은 true나 false 값만 담을 수 있음

    object o1 = 1;
    object o2 = 2.6;
    object o3 = "hello";
    // object는 모든 값을 담아 낼 수 있지만 성능적으로 좋지 않다.
    // 왜냐? 맞는 형태로 변환하는 과정이 한번 거치기 때문에 효율이 떨어짐

    // 여러 개의 자료형이 존재하는 이유
    byte n1 = 1; // 8bit
    int n2 = 1000; // 32bit
    long n3 = 1; // 64bit

    // 메모리를 효율적으로 사용하기 위해서다.
}
