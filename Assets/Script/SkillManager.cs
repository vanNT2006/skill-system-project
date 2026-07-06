using UnityEngine;
using System;

public class SkillManager : MonoBehaviour
{
    public static SkillManager Instance { get; private set; }

    [SerializeField]
    private int _skillPoints = 5;
    public int SkillPoints => _skillPoints;

    public event Action OnSkillPointsChanged;
    public event Action<SkillNodeData> OnSkillUnlocked;
    
    public bool CanUnlockSkill(SkillNodeData skillNode)
    {
        if (skillNode == null)
            return false;

        if (skillNode.IsUnlocked)
            return false;

        if (_skillPoints < skillNode.RequiredPoints)
            return false;

        foreach (var requiredSkill in skillNode.RequiredSkills)
        {
            if (!requiredSkill.IsUnlocked)
                return false;
        }

        return true;
    }

    public void UnlockSkill(SkillNodeData skillNode)
    {
        if (CanUnlockSkill(skillNode))
        {
            skillNode.IsUnlocked = true;
            _skillPoints -= skillNode.RequiredPoints;
            OnSkillUnlocked?.Invoke(skillNode);
            OnSkillPointsChanged?.Invoke();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}