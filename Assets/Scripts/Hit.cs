using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hit : MonoBehaviour
{
    // �̺�Ʈ
    [Header("Events")]
    [Space]
    public UnityEvent OnHitEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    private void Awake()
    {
        if (OnHitEvent == null)
            OnHitEvent = new UnityEvent();
        
    }








    public void OnHit(GameObject attacker, int damage, bool isCritical = false, string attackInfo = "", int hitCount = 1)
    {
        //Debug.Log($"{gameObject.name}�� {attacker.name}�κ��� {damage}�� ���ظ� �Ծ����ϴ�.");
        if (GetComponent<Rat>() && attackInfo == "Fear")
        {
            GetComponent<Rat>().Hit(attacker);
            
        }
        else
            Debug.Log($"{gameObject.name}�� {attacker.name}�κ��� {damage}�� ���ظ� �Ծ����ϴ�.");
    }
    public bool isHitTarget()
    {
        return true;
    }
}