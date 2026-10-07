using System.Collections;
using UnityEngine;

public class Boss1_TestPattern : KTH_BossPattern
{
    [SerializeField] private float duration = 2f;

    protected override void StartPattern()
    {
        Debug.Log($"{name} 패턴 시작");
        StartCoroutine(PatternRoutine());
    }
    private IEnumerator PatternRoutine()
    {
        yield return new WaitForSeconds(duration);
        Debug.Log($"{name} 패턴 종료");
        Finish();
    }
}
