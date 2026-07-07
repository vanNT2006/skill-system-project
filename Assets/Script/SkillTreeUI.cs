using UnityEngine;
using TMPro;

public class SkillTreeUI : MonoBehaviour
{
    [Header("Point Component")]
    [SerializeField]
    private TextMeshProUGUI _skillPointsText;

   private SkillNodeUI[] _nodeUIs;
   private bool _isSubcribed = false;
   

   private void Awake()
    {
        _nodeUIs = GetComponentsInChildren<SkillNodeUI>();
    }

    private void OnEnable()
    {
        SubscribeEvents();
        RefreshTreeUI();
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void Start()
    {
        SubscribeEvents();
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

    private void SubscribeEvents()
    {
        if (_isSubcribed && SkillManager.Instance == null) return;
        SkillManager.Instance.OnSkillPointsChanged += RefreshTreeUI;
        SkillManager.Instance.OnSkillUnlocked += HandleSkillUnlocked;
        _isSubcribed = true;
    }

    private void UnsubscribeEvents()
    {
        if (!(_isSubcribed && SkillManager.Instance != null)) return;
        SkillManager.Instance.OnSkillPointsChanged -= RefreshTreeUI;
        SkillManager.Instance.OnSkillUnlocked -= HandleSkillUnlocked;
        _isSubcribed = false;
    }
}