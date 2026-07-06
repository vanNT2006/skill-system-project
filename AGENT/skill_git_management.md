# Skill: Quản Lý Git & GitHub (Git & GitHub Management)

Kỹ năng này hướng dẫn AI cách thực hiện commit và quản lý mã nguồn bằng Git tuân thủ đúng quy chuẩn quốc tế, giúp lịch sử dự án rõ ràng và dễ đọc cho cả người dùng lẫn nhà tuyển dụng.

## 1. Định Dạng Commit Message (Conventional Commits)
Mỗi commit message của AI phải tuân theo cấu trúc sau:
`[loại]: [mô tả ngắn gọn bằng tiếng Việt hoặc tiếng Anh đơn giản]`

### Các loại commit (Types) bắt buộc dùng:
* **`feat`** (Feature): Khi thêm mã nguồn C# mới cho tính năng hoặc mechanic (ví dụ: `feat: add SkillNodeData class`).
* **`fix`** (Bug Fix): Khi sửa lỗi code, lỗi UI hoặc lỗi biên dịch (ví dụ: `fix: repair null reference in skill manager`).
* **`docs`** (Documentation): Thay đổi liên quan tới tài liệu, file `.md`, comment code (ví dụ: `docs: rewrite readme` hoặc `docs: update element reaction matrix`).
* **`refactor`** (Code Refactoring): Sửa đổi code để tối ưu/làm sạch mà không thay đổi logic hay thêm tính năng (ví dụ: `refactor: convert absolute paths to relative paths`).
* **`chore`** (Maintenance): Các công việc dọn dẹp, chỉnh sửa cấu hình `.gitignore`, package manager... (ví dụ: `chore: update gitignore`).

## 2. Quy Tắc Tránh Từ Ngữ "Rô-bốt" (No Over-the-top AI Language)
* Commit message phải cực kỳ **ngắn gọn, trực quan và đi vào trọng tâm**.
* **Tránh** các từ quá trang trọng hoặc mang tính học thuật của AI như: *structured, professionalized, optimized architecture, comprehensive, robust...* trừ khi thực sự cần thiết.
* Ưu tiên các mô tả tự nhiên như người viết: `docs: rewrite readme` thay vì `docs: professionalize and restructure README file with badges`.
