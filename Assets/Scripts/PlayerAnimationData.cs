using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationData 
{
    [SerializeField] private string idleParamaterName = "Idle";
    [SerializeField] private string runParamaterName = "Run";

    [SerializeField] private string attackParameterName = "Attack";
    [SerializeField] private string skillAttackParameterName = "SkillAttack";

    public int IdleParameterHash { get; private set; }
    public int RunParameterHash { get; private set; }
    public int AttackParaMeterHash { get; private set; }
    public int SkillAttackParameterHash { get; private set; }

    public void Initialize() 
    {
        IdleParameterHash = Animator.StringToHash(idleParamaterName);
        RunParameterHash = Animator.StringToHash(runParamaterName);
        AttackParaMeterHash = Animator.StringToHash(attackParameterName);
        SkillAttackParameterHash = Animator.StringToHash(skillAttackParameterName);
    }
}
