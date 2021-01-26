using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static int GetRandomIndex(int min, int max)
    {
        return Random.Range(min, max);
    }
}