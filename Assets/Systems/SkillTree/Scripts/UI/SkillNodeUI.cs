using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillNodeUI : MonoBehaviour
{
    [Header("Dữ liệu kỹ năng")]
    [SerializeField]
    private SkillNodeData _skillData;
    public SkillNodeData SkillData => _skillData;

    [Header("UI Components")]
    [SerializeField]
    [Tooltip("Tên hiển thị của kỹ năng")]
    private TextMeshProUGUI _name;
    [SerializeField]
    private Image _iconImage;
    [SerializeField]
    private Button _button;
    [SerializeField]
    private Image _backgroundImage;

    [Header("Status Colors")]
    [SerializeField]
    private Color _lockedColor = Color.red;
    [SerializeField]
    private Color _unlockedColor = Color.green;
    [SerializeField]
    private Color _unlockableColor = Color.gray;

    private RectTransform _rectTransform;
    public RectTransform RectTransform => _rectTransform ??= GetComponent<RectTransform>();

    private void Start()
    {
        if (SkillData == null)
        {
            Debug.LogError("SkillData is not assigned in SkillNodeUI.");
            return;
        }
        if (_iconImage == null || _button == null)
        {
            Debug.LogError("UI Components are not assigned in SkillNodeUI.");
            return;
        }

        _name.text = SkillData.Name;
        _iconImage.sprite = SkillData.Icon;
        _button.onClick.AddListener(OnNodeClicked);
        UpdateUI();
    }

    private void OnNodeClicked()
    {
        if (SkillData != null)
        {
            SkillManager.Instance.UnlockSkill(SkillData);
        }
    }

    public void UpdateUI()                                                                                                                                                                                                            
        {                                                                                                                                                                                                                                 
            if (SkillData == null || _backgroundImage == null || _iconImage == null || _button == null)                                                                                                                                   
            {                                                                                                                                                                                                                             
                Debug.LogWarning($"[SkillNodeUI] Bị return ở đầu hàm do thiếu liên kết trên {gameObject.name}");                                                                                                                          
                return;                                                                                                                                                                                                                   
            }                                                                                                                                                                                                                             
                                                                                                                                                                                                                                          
            if (SkillData.IsUnlocked)                                                                                                                                                                                                     
            {                                                                                                                                                                                                                             
                Debug.Log($"[SkillNodeUI] {gameObject.name} chạy vào nhánh UNLOCKED (Màu Xanh)");                                                                                                                                         
                _backgroundImage.color = _unlockedColor;                                                                                                                                                                                  
                _iconImage.color = Color.white;                                                                                                                                                                                           
                _button.interactable = false;                                                                                                                                                                                             
            }                                                                                                                                                                                                                             
            else if (SkillManager.Instance.CanUnlockSkill(SkillData))                                                                                                                                                                     
            {                                                                                                                                                                                                                             
                Debug.Log($"[SkillNodeUI] {gameObject.name} chạy vào nhánh UNLOCKABLE (Màu Xám/Trắng)");                                                                                                                                  
                _backgroundImage.color = _unlockableColor;                                                                                                                                                                                
                _iconImage.color = Color.white;                                                                                                                                                                                           
                _button.interactable = true;                                                                                                                                                                                              
            }                                                                                                                                                                                                                             
            else                                                                                                                                                                                                                          
            {                                                                                                                                                                                                                             
                Debug.Log($"[SkillNodeUI] {gameObject.name} chạy vào nhánh LOCKED (Màu Đỏ)");                                                                                                                                             
                _backgroundImage.color = _lockedColor;                                                                                                                                                                                    
                _iconImage.color = Color.gray;                                                                                                                                                                                            
                _button.interactable = false;                                                                                                                                                                                             
            }                                                                                                                                                                                                                             
        } 
}