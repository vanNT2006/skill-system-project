using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UILineConnector : MonoBehaviour
{
    [Header("Line Settings")]
    [SerializeField]
    private float _thickness = 8;
    [SerializeField]
    private Color _lockedColor = Color.red;
    [SerializeField]
    private Color _unlockedColor = Color.green;
    [SerializeField]
    private Color _unlockableColor = Color.gray;

    public SkillNodeUI StartNode { get; set; }
    public SkillNodeUI EndNode { get; set; }

    private Image _lineImage;
    private RectTransform _rectTransform;

    private void Awake()
    {
        _lineImage = GetComponent<Image>();
        _rectTransform = GetComponent<RectTransform>();

        _rectTransform.anchorMin = new Vector2 (0.5f, 0.5f);
        _rectTransform.anchorMax = new Vector2 (0.5f, 0.5f);
        _rectTransform.pivot = new Vector2 (0.5f, 0.5f);
    }

    private void Start()
    {
        UpdateLinePosition();
        UpdateLineColor();

        if (SkillManager.Instance != null)
        {
            SkillManager.Instance.OnSkillUnlocked += HandleSkillUnlocked;
        }
    }

    private void OnDestroy()
    {
        if (SkillManager.Instance != null)
        {
            SkillManager.Instance.OnSkillUnlocked -= HandleSkillUnlocked;
        }
    }

    public void UpdateLinePosition()
    {
        if (StartNode == null || EndNode == null) return;

        // Get the positions of the start and end nodes
        Vector2 startPos = StartNode.RectTransform.anchoredPosition;
        Vector2 endPos = EndNode.RectTransform.anchoredPosition;

        // Calculate the position
        _rectTransform.anchoredPosition = (startPos + endPos) / 2f;

        // Calculate size
        float distance = Vector2.Distance(startPos, endPos);
        _rectTransform.sizeDelta = new Vector2(distance, _thickness);

        // Calculate rotation angle
        Vector2 direction = endPos - startPos;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _rectTransform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void UpdateLineColor()
    {
        if (StartNode == null || EndNode == null || _lineImage == null) return;

        bool isStartUnlocked = StartNode.SkillData.IsUnlocked;
        bool isEndUnlocked = EndNode.SkillData.IsUnlocked;

        if (isStartUnlocked && isEndUnlocked)
        {
            _lineImage.color = _unlockedColor;
        }
        else if (isStartUnlocked || isEndUnlocked)
        {
            _lineImage.color = _unlockableColor;
        }
        else
        {
            _lineImage.color = _lockedColor;
        }
    }

    public void HandleSkillUnlocked(SkillNodeData unlockedSkill)
    {
        UpdateLineColor();
    }

    public void ConnectNodes(SkillNodeUI startNode, SkillNodeUI endNode)
    {
        StartNode = startNode;
        EndNode = endNode;
        UpdateLinePosition();
        UpdateLineColor();
    }
}