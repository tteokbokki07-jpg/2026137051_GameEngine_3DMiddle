using Unity.VisualScripting;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("for")]
    void ForBasic()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    //2.2
    //7. true
    //8. false
    //9. true
    //10. false - (!(hp > 0) == isDead) (!(false)(를반대로해서 true) == true) = 정답 true

    //2.5
    //A. >
    //B. &&
    //C. !
    //D. <=
    //E. ||

    //3.3
    //5~7. C B A - true가 찍히면 다음 else if는 검사안함(C )
    //9~11. A B C

    //3.9
    //Mathf.Min(a, b)
    //Mathf.Max(c, d)
    //Mathf.Clamp(v, min, max) (현재값, 최소값, 최대값) (67, 0, 50) > (50)
    //값이 지정범위를 벗어나지 않도록 제한
    //Mathf.RoundToInt(f) - 가장 가까운 정수. (3.6f) > 4

//    4.2
//4. 0 1 2
//5. 1 4 7 10
//6. 5 3 1
//9. 15 - 1 + 2 + 3 + 4 반복 끝나고 i <= 4에 걸려서 for문 종료

//4.13
//8. 1 2 4 5 7
//12. 12

//5.1
//A. <=
//B. else if
//C. case
//D. break
//E. else? - default

//5.3 (문제 풀기전에 정답당함
//A. 2
//B. + 2
//C. <=
//D.

//5.5 (문제풀시간없22)
//7. 5 7 7
//9. 버그
//10. 
//12. 안됨
}
