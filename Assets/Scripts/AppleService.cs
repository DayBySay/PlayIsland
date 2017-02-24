using UnityEngine;
using System.Collections;
using UniRx;
using System;

[RequireComponent(typeof(Timer))]
public class AppleService : MonoBehaviour {
    [SerializeField]
    private GameObject blueApple, redApple, goldApple;

    public GameObject AppleWithStyle(Apple.STYLE style)
    {
        GameObject apple = null;
        switch (style)
        {
            case Apple.STYLE.RED:
                apple = redApple;
                break;
            case Apple.STYLE.BLUE:
                apple = blueApple;
                break;
            case Apple.STYLE.GOLDEN:
                apple = goldApple;
                break;
        }

        return apple;
    }
    [SerializeField]
    private Transform[] applePivots;

    public enum ApplePivot
    {
        center,
        left1,
        left2,
        left3,
        right1,
        right2,
        right3,
    }

    public void CreateApples() {
        Timer timer = GetComponent<Timer>();
        timer.OnTimeChanged.Subscribe(time =>
            {
                CreateApple(Apple.STYLE.RED, (ApplePivot)System.Enum.ToObject(typeof(ApplePivot), (int)UnityEngine.Random.Range(0, 7)));
            });
    }

    public void CreateApple(Apple.STYLE style, ApplePivot pivot) {
        GameObject apple = AppleWithStyle(style);
        Instantiate(apple);
        apple.transform.position = applePivots[(int)pivot].transform.position;
	}
}
