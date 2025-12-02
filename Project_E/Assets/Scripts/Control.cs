using UnityEngine;

public class Control : MonoBehaviour
{
    public int a;
    public int b;
    public string fruit;

    void Start()
    {
        if (a > b)
        {
            Debug.Log("a 가 b 보다 큽니다.");
        }
        else if (a < b)
        {
            Debug.Log("b 가 a 보다 큽니다.");
        }
        else
        {
            Debug.Log("a 와 b 는 같습니다.");
        }

        switch (this.fruit)
        {
            case "사과":
                Debug.Log("사과는 빨갛습니다.");
                break;
           
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i 의 값: " + i);
        }

        while (a < 10)
        {
            Debug.Log("a 의 값: " + a);
            a++;

            string[] array = new string[5];
            array[0] = "강대원";
            array[1] = "민영희";
            array[2] = "박두팔";
            array[3] = "안선생";
            array[4] = "함수빈";
        }
    }
}