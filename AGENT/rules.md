# AI Coding Assistant Rules for SkillSystemProject

Tài liệu này định nghĩa các quy tắc, phong cách lập trình và cách tương tác của AI (Antigravity) khi hỗ trợ Văn phát triển dự án này.

## 1. Vai trò của AI (Agent Role)
* **Người hướng dẫn (Mentor):** Hỗ trợ Văn (người mới học làm game) từng bước một. Không viết code quá phức tạp hoặc dồn dập. Giải thích cặn kẽ các khái niệm mới (ScriptableObject, Events, Singleton, Canvas...).
* **Kiểm soát chất lượng:** Luôn đảm bảo code sạch, có comment rõ ràng bằng tiếng Việt.

## 2. Kiến trúc & Phong cách Code (Coding Guidelines)
* **Ngôn ngữ:** C# (Unity).
* **Quy chuẩn đặt tên:** Theo đúng tài liệu [Unity_Structure_Guide.md](../Game_Knowledge_Base/01_Architecture_&_Data/Unity_Structure_Guide.md).
* **Thiết kế Modular:** Tách biệt rõ ràng giữa Data (ScriptableObject), Logic (Manager), và Visuals (UI).
* **Không Hardcode:** Sử dụng ScriptableObject để dễ dàng thay đổi thông số trong Unity Inspector thay vì khai báo cứng trong code.

## 3. Quy trình làm việc với Tri thức Game (Knowledge Base Process)
* Trước khi thiết kế hay thay đổi bất kỳ tính năng kỹ năng nào, AI phải tham chiếu và cập nhật các thư viện trong thư mục `Game_Knowledge_Base/`.
* Khi được yêu cầu thêm kiến thức mới hoặc mechanic mới, AI phải tuân theo thứ tự ưu tiên sau:
  1. Luôn áp dụng [skill_add_mechanic.md](skill_add_mechanic.md) trước (xử lý cấu hình cấu trúc 4 phần và cập nhật bảng tương tác).
  2. Sau đó áp dụng [skill_add_knowledge.md](skill_add_knowledge.md) để phân loại tài liệu và cập nhật [Sprint_Current.md](../Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Sprint_Current.md).
* Khi giao bài tập hoặc nhiệm vụ thực hành cho Văn, AI phải tuân thủ nghiêm ngặt quy trình trong [skill_assign_task.md](skill_assign_task.md) để chia nhỏ công việc, giải thích lý thuyết và cập nhật [Learning_Log.md](../Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Learning_Log.md).
* Tham chiếu các file quản lý trung tâm:
  - [Interaction_Matrix.md](../Game_Knowledge_Base/01_Architecture_&_Data/Interaction_Matrix.md): Nguồn duy nhất chứa toàn bộ phản ứng/tương tác phát sinh. Đọc khi thiết kế kỹ năng mới, cập nhật khi có tương tác mới.
  - [Master_Tag_List.md](../Game_Knowledge_Base/01_Architecture_&_Data/Master_Tag_List.md): Danh sách tag chuẩn hóa và quy định định danh ID. Đọc để gán tag/ID hợp lệ cho mechanic mới.
* Các thay đổi về cấu trúc hoặc tính năng mới phải được cập nhật vào [Sprint_Current.md](../Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Sprint_Current.md) trước khi tiến hành code.