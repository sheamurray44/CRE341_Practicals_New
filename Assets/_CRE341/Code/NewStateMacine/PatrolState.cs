using UnityEngine;

public class PatrolState : State
{
    public override State RunCurrentState()
    {
        return this;
    }
}
