using UnityEngine;
using TMPro;

public class SkillTreeUI : MonoBehaviour
{
    [Header("Point Component")]
    [SerializeField]
    private TextMeshProUGUI _skillPointsText;

   private SkillNodeUI[] _nodeUIs;

   private void Awake()
    {
        _nodeUIs = GetComponentsInChildren<SkillNodeUI>();
    }

    private void OnEnable()
    {
        if (SkillManager.Instance != null)
        {
            SkillManager.Instance.OnSkillPointsChanged += RefreshTreeUI;
            SkillManager.Instance.OnSkillUnlocked += HandleSkillUnlocked;
        }
    }

    private void OnDisable()
    {
        if (SkillManager.Instance != null)
        {
            SkillManager.Instance.OnSkillPointsChanged -= RefreshTreeUI;
            SkillManager.Instance.OnSkillUnlocked -= HandleSkillUnlocked;
        }
    }

    private void Start()
    {
        RefreshTreeUI();
    }

    private void RefreshTreeUI()
    {
        if (_skillPointsText != null && SkillManager.Instance != null)
        {
            _skillPointsText.text = $"Skill Points: {SkillManager.Instance.SkillPoints}";
        }

        foreach (var nodeUI in _nodeUIs)
        {
            nodeUI.UpdateUI();
        }
    }

    private void HandleSkillUnlocked(SkillNodeData unlockedSkill)
    {
        RefreshTreeUI();
    }
}