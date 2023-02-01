using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingBag : MonoBehaviour, IHurtResponder
{
    [SerializeField] private bool m_targetable = true;
    [SerializeField] private Transform m_targetTransform;
    [SerializeField] private Rigidbody m_rbag;
    private int health = 100;

    private List<Hurtbox> m_hurtboxes = new List<Hurtbox>();

    private void Start()
    {
        m_hurtboxes = new List<Hurtbox>(GetComponentsInChildren<Hurtbox>());
        foreach (Hurtbox _hurtbox in m_hurtboxes)
            _hurtbox.HurtResponder = this;
    }

    private void Update()
    {
        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public bool CheckHit(HitData data)
    {
        return true;
    }

    public void Response(HitData data)
    {
        health -= data.damage;
        Debug.Log("health = " + health + " damage = " + data.damage);
    }
}
