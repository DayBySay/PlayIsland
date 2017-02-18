using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Timer : MonoBehaviour {
    [SerializeField]
    private int limit = 60;

    private Subject<int> timerSubject = new Subject<int>();
    public IObservable<int> OnTimeChanged;

    private void Start()
    {
        StartCoroutine(TimerContinue());
    }

    IEnumerator TimerContinue()
    {
        int time = limit;
        while (time > 0)
        {
            time--;
            timerSubject.OnNext(time);
            yield return new WaitForSeconds(1);
        }
    }
}
