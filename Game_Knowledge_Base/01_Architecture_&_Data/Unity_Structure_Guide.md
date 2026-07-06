# Hướng Dẫn Kiến Trúc & Cấu Trúc Unity

Tài liệu này định nghĩa cách tổ chức code, quản lý thư mục và các quy chuẩn lập trình trong dự án.

## 1. Cấu Trúc Thư Mục Trong Assets
* `Assets/Scripts/Core`: Chứa các Script quản lý hệ thống (GameManager, SoundManager...).
* `Assets/Scripts/Skills`: Chứa các class liên quan đến logic kỹ năng (SkillManager, SkillNode...).
* `Assets/Scripts/UI`: Quản lý hiển thị cây kỹ năng và HUD.
* `Assets/ScriptableObjects/Skills`: Nơi lưu trữ các file asset kỹ năng được tạo ra.

## 2. Quy Chuẩn Đặt Tên (Naming Conventions)
* **Class / Struct / Enum:** PascalCase (ví dụ: `SkillManager`, `SkillType`).
* **Biến private / protected:** camelCase có dấu gạch dưới phía trước (ví dụ: `_skillPoints`, `_currentLevel`).
* **Biến public / Property:** PascalCase (ví dụ: `SkillPoints`, `CurrentLevel`).
* **Hàm (Method):** PascalCase (ví dụ: `UnlockSkill()`, `ApplyModifier()`).
