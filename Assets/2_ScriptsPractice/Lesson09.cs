using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int attack = 10;
    int killCount = 0;

    void Start()
    {
        Debug.Log(attack);
    }
    void Update()
    {
        
    }


    void Hit()
    {
        killCount = killCount + 1;
    }

    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }
    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }
}
// /나누기 %나머지
// float > int = (소수점 버림)
// && 둘다 참이어야 참
// || 하나만 참이어도 참

//while

//continue - 건너뛰기
//break 가장 가까운 반복문 종료

//1.11
//A class
//B contextmenu--대소문자 구분하기(ContextMenu)
//C void
//D Log
//E 6번줄

//2.3
//6. 7
//8. 20
//11. 20

//2.9
//A string
//B int
//C float
//D bool
//E int - int * float를 int로 받으면 에러

//3.3 (어려움...)
//5. 21474... -   2147483647
//7. -21474... -   -2147483647
//10. 255 -   byte 255+1 = 0

//3.6 (이거도어려움)
//5. 0.3 == 0.3 - false, 아무튼 뭔가 다름
//8. 0.5 (?) -  int나눗셈이 먼저라 0

//3.9 (공부필요)
//A int
//B byte
//C char
//D f
//E bool

//4.2
//6. 0
//7. 0.7
//8. 3
//9. 3.5
//10. 1

//4.6
//6. 합: 3 - 단순히 숫자를 붙인 것(합: 12)
//7. 합: 3
//8. 3점
//9. HP 3
