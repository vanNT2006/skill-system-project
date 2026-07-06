# Sprint Hiện Tại (Sprint Current)

Nơi quản lý các nhiệm vụ cần thực hiện trong giai đoạn phát triển hiện tại.

## 🎯 Mục Tiêu Sprint: Xây dựng Core Skill System & UI đơn giản
* Thiết lập hệ thống dữ liệu kỹ năng dựa trên ScriptableObject.
* Tạo cấu trúc dữ liệu cây kỹ năng (mối quan hệ cha-con).
* Xây dựng giao diện UI (Cây kỹ năng dạng nút bấm).

## 📋 Danh Sách Nhiệm Vụ (Task List)
- [x] **Task 1:** Tạo lớp `SkillNodeData` kế thừa từ `ScriptableObject`.
- [x] **Task 2:** Tạo lớp `SkillManager` quản lý logic mở khóa kỹ năng và lưu trữ Skill Points.
- [ ] **Task 3:** Thiết kế UI Canvas đơn giản trong Unity (chứa các nút kỹ năng).
- [ ] **Task 4:** Viết script `SkillNodeUI` để kết nối nút bấm UI với dữ liệu `SkillNodeData`.
- [ ] **Task 5:** Vẽ đường nối (Lines) giữa các nút kỹ năng tiên quyết và kỹ năng tiếp theo.
