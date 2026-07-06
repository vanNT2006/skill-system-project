# ScriptableObject Templates

Tài liệu này phác thảo cấu trúc của các ScriptableObject dùng để cấu hình dữ liệu kỹ năng.

## Quy tắc bắt buộc về Field & Property (C# Convention)

Mọi ScriptableObject trong dự án PHẢI tuân theo encapsulation chuẩn C#, không được để public field trực tiếp trừ trường hợp ngoại lệ nêu dưới đây.

### Cách viết bắt buộc:
```csharp
[SerializeField]
[Tooltip("Mô tả rõ field này dùng để làm gì")]
private string _tenBien;

// Property PascalCase, chỉ có get, không có set -> chống bị script khác gán đè
public string TenBien => _tenBien;
```

### Quy tắc đặt tên:
- Private field: `_camelCase` (có dấu gạch dưới đầu).
- Public property: `PascalCase`, cùng tên với field nhưng bỏ gạch dưới và viết hoa chữ đầu.
- Property chỉ dùng getter (`=>`) — KHÔNG thêm `set` trừ khi có lý do rõ ràng (vd: giá trị cần thay đổi lúc runtime bởi chính hệ thống nội bộ, không phải từ bên ngoài).

### Khi nào BẮT BUỘC dùng encapsulation (private + property):
- ID, tên, mô tả, icon — dữ liệu định danh không được phép sửa từ bên ngoài.
- Chỉ số cấu hình (requiredPoints, damage, cooldown...) — dữ liệu balance, tránh bị script khác vô tình gán đè.
- Reference tới asset khác (SkillNodeData[], Sprite...).

### Khi nào ĐƯỢC PHÉP dùng public field trực tiếp (ngoại lệ):
- Biến trạng thái runtime thuần túy, có mục đích cho phép Inspector hoặc script khác chỉnh trực tiếp lúc debug/test (vd: biến debug đặc biệt).
- Nếu dùng ngoại lệ này, PHẢI ghi rõ comment `// [Ngoại lệ] Lý do: ...` ngay phía trên field.

---

## 1. SkillNodeData (ScriptableObject gốc)
Lưu trữ thông tin cơ bản của một node kỹ năng trên cây kỹ năng.

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Skills/Skill Node")]
public class SkillNodeData : ScriptableObject
{
    [Header("Thông Tin Định Danh")]
    [SerializeField] [Tooltip("ID duy nhất của kỹ năng (Ví dụ: ELEM_FIRE, FORM_PROJECTILE)")]
    private string _id;
    public string Id => _id;

    [SerializeField] [Tooltip("Tên hiển thị của kỹ năng")]
    private string _skillName;
    public string SkillName => _skillName;

    [SerializeField] [TextArea] [Tooltip("Mô tả chi tiết kỹ năng")]
    private string _description;
    public string Description => _description;

    [SerializeField] [Tooltip("Icon hiển thị trên UI")]
    private Sprite _icon;
    public Sprite Icon => _icon;

    [Header("Requirements")]
    [SerializeField] [Tooltip("Số điểm kỹ năng cần để mở node này")]
    private int _requiredPoints = 1;
    public int RequiredPoints => _requiredPoints;

    [SerializeField] [Tooltip("Các kỹ năng cần mở trước node này")]
    private SkillNodeData[] _requiredSkills;
    public SkillNodeData[] RequiredSkills => _requiredSkills;

    [Header("Status")]
    [field: SerializeField] [Tooltip("Trạng thái mở khóa của kỹ năng")]
    public bool IsUnlocked { get; set; } = false;
}
```

## 2. SpellComponent (Dành cho việc ghép chiêu thức)
Dành cho hệ thống chế kỹ năng (nếu có):
* **SpellForm:** Hình thái (Projectile, Ray, Zone...)
* **SpellElement:** Nguyên tố (Fire, Ice, Light...)
* **SpellModifier:** Bộ biến đổi (Fork, Bounce, Piercing...)

Mỗi loại trên đều là ScriptableObject riêng, PHẢI áp dụng đúng quy tắc encapsulation ở trên. ID của từng loại phải theo prefix quy định trong `Master_Tag_List.md` (`ELEM_`, `FORM_`, `MOD_`).