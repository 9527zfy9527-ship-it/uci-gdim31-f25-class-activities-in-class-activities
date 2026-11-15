

using UnityEngine;

public class BatW6 : MonoBehaviour
{
    // 可以在 Inspector 中调整速度
    [SerializeField] private float _speed = 3f; 
    
    private bool _isChasing = false;
    private Transform _targetPlayer;

    // 供 BatManager 调用的“开始追逐”方法
    public void StartChasing(Transform playerTransform)
    {
        _isChasing = true;
        _targetPlayer = playerTransform;
    }

    // 供 BatManager 调用的“停止追逐”方法
    public void StopChasing()
    {
        _isChasing = false;
        _targetPlayer = null;
    }

    private void Update()
    {
        // 如果正在追逐，就朝玩家的位置移动
        if (_isChasing && _targetPlayer != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position, 
                _targetPlayer.position, 
                _speed * Time.deltaTime
            );
        }
    }
}