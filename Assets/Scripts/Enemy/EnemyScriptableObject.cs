using UnityEngine;

[CreateAssetMenu(menuName = "EnemySO")]
public class EnemyScriptableObject : ScriptableObject
{
    [Header("Enemy Properties")]
    public Vector2 direction;

    public void Init(Transform transform)
    {
        transform.position = GetRandomPositionOnScreen();
        direction = Vector2.down;
    }

    private Vector2 GetRandomPositionOnScreen()
    {
        float x = Random.Range(-Camera.main.aspect * Camera.main.orthographicSize,
                               Camera.main.aspect * Camera.main.orthographicSize);
        float y = Random.Range(Camera.main.orthographicSize + 1,
                               Camera.main.orthographicSize * 2);
        return new Vector2(x, y);
    }
}
