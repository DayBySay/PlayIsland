using UnityEngine;
using System.Collections;
using UniRx;

public class Apple : MonoBehaviour {
	public enum STYLE {
		RED,
		BLUE,
		GOLDEN,
	}

	[SerializeField]
	private int point;
	[SerializeField]
	private STYLE style;

    public void Catch()
    {
        StartCoroutine(CatchWithSeconds(0.2f));
    }

    IEnumerator CatchWithSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        Destroy(gameObject);
    }
}