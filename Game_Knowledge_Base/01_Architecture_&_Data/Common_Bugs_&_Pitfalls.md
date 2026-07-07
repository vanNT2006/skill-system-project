# Nhật Ký Tránh Bẫy & Lỗi Logic (Common Bugs & Pitfalls)

Tài liệu này ghi lại các lỗi logic, lỗi vận hành hệ thống Unity/C# đã phát sinh trong dự án. AI và người học phải đọc tài liệu này trước khi thiết kế tính năng mới hoặc viết code mẫu để tránh lặp lại sai lầm.

---

## 🚨 Lỗi 1: Lệch pha khởi chạy do khác biệt vòng đời (Unity Lifecycle Execution Order Race Condition)

### 1. Mô tả hiện tượng:
* Bấm Play game, điểm số hiển thị đúng nhưng khi Click nút nâng kỹ năng thì UI hoàn toàn trơ ra không cập nhật điểm mới hay đổi màu nút. Chỉ khi tắt game mở lại mới thấy thay đổi.

### 2. Nguyên nhân kỹ thuật:
* Unity tải các đối tượng trong Scene theo thứ tự ngẫu nhiên.
* Hàm `OnEnable()` của `SkillTreeUI` (trên UI Panel) chạy **trước** khi hàm `Awake()` của `SkillManager` (trên GameManager) kịp chạy.
* Lúc này, địa chỉ tĩnh `SkillManager.Instance` vẫn đang bằng `null`.
* Dẫn đến việc UI kiểm tra điều kiện gán sự kiện `if (SkillManager.Instance != null)` bị Sai và bỏ qua hoàn toàn việc đăng ký lắng nghe sự kiện (`+=`). UI bị "liệt" tín hiệu lúc chơi.

### 3. Giải pháp phòng ngừa (Best Practice):
* **Không đăng ký sự kiện kết nối ngoài trong `OnEnable` ở lần load scene đầu tiên** nếu chưa chắc chắn đối tượng kia đã Awake.
* **Giải pháp chuẩn:** Sử dụng hàm `Start()` (luôn chạy sau khi tất cả `Awake` của game chạy xong) để đăng ký dự phòng, kết hợp dùng một biến cờ hiệu `bool _isSubscribed` để quản lý bật/tắt an toàn:
  ```csharp
  private void Start() { SubscribeEvents(); }
  private void OnEnable() { SubscribeEvents(); }
  private void OnDisable() { UnsubscribeEvents(); }
  ```

---

## 🚨 Lỗi 2: Trùng lặp liên kết Image trong UI (Overlapping Image References)

### 1. Mô tả hiện tượng:
* Bấm Play game, log báo đã chạy vào đúng nhánh trạng thái đổi màu (ví dụ nhánh mở khóa màu Xanh), nhưng trên màn hình thực tế nút bấm vẫn giữ nguyên màu trắng mặc định.

### 2. Nguyên nhân kỹ thuật:
* Trong script `SkillNodeUI`, ô kéo thả `Background Image` và `Icon Image` bị kéo trùng vào **cùng một đối tượng Image** duy nhất trên Button.
* Trong code chạy tuần tự:
  ```csharp
  _backgroundImage.color = _unlockedColor; // (Đổi sang màu Xanh)
  _iconImage.color = Color.white;          // (Đè lại thành màu Trắng)
  ```
  Dẫn đến việc hai câu lệnh tự triệt tiêu lẫn nhau, làm nút bấm luôn có màu trắng.

### 3. Giải pháp phòng ngừa (Best Practice):
* Luôn thiết kế cấu trúc nút bấm UI dạng phân cấp rõ ràng:
  * Nút Cha (chứa component `Button` + `Image` làm nền).
  * Nút Con 1 (chứa component `TextMeshPro` hiển thị chữ).
  * Nút Con 2 (chứa component `Image` làm Icon hiển thị).
* Khi kéo thả vào Inspector, đảm bảo kéo **Nút Cha** vào ô `Background Image` và kéo **Nút Con 2** vào ô `Icon Image`.

