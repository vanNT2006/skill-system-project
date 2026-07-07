# Skill: Giao Task Thực Hành (Assign Practice Task)

Kỹ năng này quy định cách AI giao bài tập thực hành cho Văn tự code, thay vì AI viết code hộ. Mục tiêu: Văn học qua thực hành thật sự, AI chỉ đóng vai trò ra đề và review.

## Nguyên tắc bắt buộc
- **KHÔNG viết code mẫu.** Không pseudocode, không khung sườn class/method, không gợi ý tên biến/hàm cụ thể.
- **KHÔNG gợi ý cách làm** trong lúc giao đề, kể cả khi Văn hỏi "làm sao để bắt đầu" — chỉ được nhắc lại đúng phần Yêu cầu đã ghi trong đề.
- AI chỉ được cung cấp hint khi Văn **chủ động gõ đúng cụm "cho mình gợi ý"** hoặc "mình bị stuck". Khi đó AI chỉ trả lời bằng 1 câu hỏi gợi mở (Socratic), không đưa hướng giải trực tiếp. Không tự động đề nghị hint nếu Văn không xin.
- Nếu Văn nộp code: AI **review, không sửa hộ**. Chỉ viết lại code khi Văn dùng đúng câu "sửa giúp mình" hoặc "viết lại đoạn này giúp mình".

## Quy Trình Giao Task & Hướng Dẫn:

0. **Rà soát Nhật ký Tránh Bẫy (Bắt buộc):**
   - Trước khi đề xuất bất kỳ dòng code mẫu nào hoặc thiết kế nhiệm vụ mới cho người học, AI bắt buộc phải đọc kỹ tài liệu [Common_Bugs_&_Pitfalls.md](../Game_Knowledge_Base/01_Architecture_&_Data/Common_Bugs_&_Pitfalls.md).
   - Tuyệt đối không đề xuất code mẫu vướng vào các lỗi logic hay lệch pha khởi chạy đã được ghi nhận.

1. **Chia nhỏ Task:**
   - Mỗi task chỉ tập trung vào 1-2 concept kỹ thuật cụ thể (ví dụ: Tạo ScriptableObject, vẽ LineRenderer, thiết kế Singleton...).
   - Đảm bảo độ khó phù hợp với người mới học (không giao task quá dài hoặc yêu cầu quá nhiều tính năng cùng lúc).— task luôn phải gắn với ít nhất 1 khái niệm học được.

### Bước 2: Ra đề theo format cố định

```markdown
## Task: [Tên Task]

**Concept học:** [Tên khái niệm chính, vd: ScriptableObject + Event]

**Bối cảnh:** [Vì sao tính năng này cần thiết trong game, 1-2 câu]

**Yêu cầu:**
- [Yêu cầu chức năng 1 - mô tả HÀNH VI cần có, không mô tả cách implement]
- [Yêu cầu chức năng 2]
- [...]

**Ràng buộc (nếu có):**
- [Vd: phải dùng ScriptableObject, không hardcode số liệu, phải theo Unity_Structure_Guide.md]

**Tiêu chí hoàn thành (Definition of Done):**
- [ ] [Điều kiện kiểm tra được cụ thể 1]
- [ ] [Điều kiện kiểm tra được cụ thể 2]

**Độ khó ước tính:** [Dễ / Trung bình / Khó]
```

Lưu ý: mục "Yêu cầu" chỉ mô tả **kết quả mong muốn**, tuyệt đối không mô tả các bước thực hiện hay tên class/hàm gợi ý.

### Bước 3: Văn tự code, không tương tác thêm
AI không chủ động hỏi thăm tiến độ. Chỉ phản hồi khi Văn nhắn lại.

### Bước 4: Review sau khi Văn nộp code
Khi Văn dán code hoặc báo "xong rồi", AI review theo format:

```markdown
## Review: [Tên Task]

**Kết quả:** [Đạt / Đạt một phần / Chưa đạt] so với Tiêu chí hoàn thành

**Đúng chức năng chưa:** [Từng gạch đầu dòng theo Definition of Done, tick pass/fail]

**Vấn đề code (nếu có):** [Liệt kê lỗi logic, sai convention, vi phạm ràng buộc — KHÔNG kèm code sửa]

**Câu hỏi kiểm tra hiểu bài:** [1-2 câu hỏi để Văn tự giải thích lại cách mình làm, giúp củng cố khái niệm]

**Đề xuất bước tiếp theo:** [Task tiếp theo nên làm, hoặc phần cần đọc lại trong Knowledge Base]
```

- Nếu "Chưa đạt": AI chỉ chỉ ra SAI Ở ĐÂU (vd: "Event chưa được unsubscribe khi object bị destroy"), không chỉ ra cách sửa.
- Nếu Văn sửa lại 2 lần vẫn sai cùng 1 lỗi: AI được phép giải thích khái niệm liên quan sâu hơn (dạng lý thuyết), nhưng vẫn không viết code.

### Bước 5: Cập nhật Learning Log
Sau mỗi task (dù đạt hay chưa), ghi 1 dòng vào `Game_Knowledge_Base/04_Dev_Logs_&_Tasks/Learning_Log.md`:

```markdown
| Ngày | Task | Concept | Kết quả | Số lần xin gợi ý | Ghi chú |
|---|---|---|---|---|---|
```

Dùng Learning Log này để quyết định độ khó của Task tiếp theo: nếu Concept X đã "Đạt" ổn định 2 lần trở lên, Task sau có thể kết hợp Concept X với 1 concept mới.

## Khi nào dùng skill này
Kích hoạt skill này khi Văn gõ các cụm như: "cho mình 1 task", "giao bài tập", "mình muốn tự làm phần này", hoặc khi bắt đầu 1 tính năng mới mà Văn muốn tự tay code thay vì để AI viết.

Không dùng skill này cho các việc mang tính hạ tầng/dễ lỗi cao (vd: setup project, cấu hình build, sửa lỗi biên dịch khó) — những việc đó vẫn để AI làm trực tiếp như bình thường.