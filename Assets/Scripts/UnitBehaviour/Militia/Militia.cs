using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Militia : Unit, IDamageble, IMoveble
{
    public int Health { get; set; }
    public float Speed { get; set; }

    public void MoveToTarget(Transform target)
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(float damage)
    {
        throw new System.NotImplementedException();
    }

    protected override void Initialize()
    {
        foreach(State state in InitializeStates())
        {
            _stateMachine.AddState(state);
        }
    }

    private List<State> InitializeStates()
    {
        List<State> states = new List<State>();
        states.Add(new MoveState(this, _stateMachine, this));
        states.Add(new AttackState(this, _stateMachine));
        return states;
    }
}
