using System.Collections.Generic;
using UnityEngine;

public class RandomSystem
{

    /// <summary>
    /// 가중치 중 랜덤으로 인덱스 뽑기
    /// </summary>
    /// <param name="probs"></param>
    /// <returns></returns>
    public int GetRandomInt(List<int> probs)
    {
        int total = 0;
        foreach (int elem in probs)
        {
            total += elem;
        }
        float randomPoint = Random.value * total;
        for (int i = 0; i < probs.Count; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Count - 1;
    }
}
