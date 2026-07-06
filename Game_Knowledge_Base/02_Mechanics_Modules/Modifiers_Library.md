# Thư Viện Các Bộ Điều Chỉnh (Modifiers Library)

Bộ điều chỉnh (Modifiers) dùng để **thay đổi hành vi vật lý hoặc logic** của một kỹ năng cơ bản khi được lắp ghép vào.

## Các Modifiers Đề Xuất

1. **Bouncing (Nảy)**
   - *Tác động:* Đạn bay (Projectile) sẽ nảy lại khi va chạm với tường hoặc kẻ địch thay vì biến mất ngay lập tức.
   - *Thông số:* Số lần nảy tối đa (Max Bounces).

2. **Splitting (Phân tách / Chia nhánh)**
   - *Tác động:* Khi va chạm hoặc sau một khoảng thời gian, đạn sẽ vỡ ra thành các viên đạn nhỏ hơn.
   - *Thông số:* Số lượng đạn con (Split Count), Góc phân tách.

3. **Piercing (Xuyên thấu)**
   - *Tác động:* Đạn đi xuyên qua các kẻ địch thay vì dừng lại ở kẻ địch đầu tiên.
   - *Thông số:* Số lượng kẻ địch xuyên qua (Pierce Count).

4. **Homing (Tự tìm mục tiêu)**
   - *Tác động:* Đạn tự động bẻ lái hướng về mục tiêu gần nhất.
   - *Thông số:* Lực bẻ lái (Turn Speed), Bán kính dò tìm (Detection Radius).
