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

