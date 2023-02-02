using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Properties")]
    public string Name;
    [TextArea(2, 5)]
    public string Description;
    public int Level;
    public float speed;
    public int damage;

    public Vector3 centerScreenPos;
    public EnemyScriptableObject enemyProperties;

    private void Awake()
    {
        centerScreenPos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
    }

    private void Start()
    {
        enemyProperties.Init(transform);
    }

    private void Update()
    {
        Vector3 direction = (centerScreenPos - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}