using UnityEngine;
using TMPro;

public class SkillTreeUI : MonoBehaviour
{
    [Header("Point Component")]
    [SerializeField]
    private TextMeshProUGUI _skillPointsText;

    [Header("Line Connector")]
    [SerializeField]
    private GameObject _linePrefab;


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

        CreateLineConnections();

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
        if (_isSubcribed || SkillManager.Instance == null) return;
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

    private void CreateLineConnections()
    {
        foreach (var nodeUI in _nodeUIs)
        {
            foreach (var requiredSkill in nodeUI.SkillData.RequiredSkills)
            {
                SkillNodeUI startNodeUI = FindNodeUI(requiredSkill);
                if (startNodeUI == null)
                {
                    continue; 
                }

                GameObject lineObj = Instantiate(_linePrefab, transform);
                UILineConnector lineConnector = lineObj.GetComponent<UILineConnector>();
                if (lineConnector == null)
                {
                    Debug.LogError("Line prefab does not have a UILineConnector component.");
                    Destroy(lineObj);
                    continue;
                }

                lineConnector.ConnectNodes(startNodeUI, nodeUI);

                lineObj.GetComponent<RectTransform>().SetAsFirstSibling();
            }
        }
    }

    private SkillNodeUI FindNodeUI(SkillNodeData skillData)
    {
        foreach (var nodeUI in _nodeUIs)
        {
          if (nodeUI.SkillData == skillData)  return nodeUI;
        } 
        return null;
    }
}