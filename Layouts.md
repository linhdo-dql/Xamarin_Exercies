# Layouts
## StackLayout
### StackLayout là loại layout mà các view (control) trong nó được sắp xếp cạnh nhau theo chiều ngang hoặc chiều dọc.

>Thuộc tính quan trọng
+ Orientation="<Horizontal>/<Vertical>" - Xác định chiều sắp xếp Ngang hoặc Dọc
+ Spacing="" - Quy định khoảng cách giữa các thành phần bên trong layout theo chiều của layout

## Grid
### Grid là loại layout mà các view (control) được tổ chức theo hàng và cột.
>Thuộc tính quan trọng
+ Grid.ColumnDefinitions - Dùng để quy định bố cục theo cột của Grid. 
  Thuộc tính con: Witdth="(1)" Quy định chiều rộng tương đối hoặc tuyệt đối của các cột.
+ Grid.RowDefinitons - Dùng để quy định bố cục theo hàng của Grid. 
  Thuộc tính con: Height="(1)" Quy định chiều cao tương đối hoặc tuyệt đối của các hàng.

Trong (1) có thể là các loại giá trị:
+ Tuyệt đối - Quy định kích thước xác định tuyệt đối
+ Auto - Quy định kích thước theo nội dụng trong control
+ "*" - Quy định kích thước tương đối

  *(Số lượng các dòng ColumnDefinitions và RowDefinitons tương đương với số hàng và số cột trong Grid)*
  
+ ColumnSpacing="" - Xác định khoảng các giữa các cột
+ RowSpacing="" - Xác định khoảng cách giữa các hàng

>Các thuộc tính tại các control

+ Grid.Row="" - Xác định chỉ số hàng trong Grid của control(bắt đầu từ 0)
+ Grid.Column="" - Xác định chỉ số cột trong Grid của control(bắt đầu từ 0)
+ Grid.RowSpan="" - Xác định số lượng hàng gộp của control trong Grid (không thể > só lượng hàng trong Grid)
+ Grid.ColumnSpan="" - Xác định số lượng cột gộp của control trong Grid (không thể > só lượng cột trong Grid)

## AbsoluteLayout
### AbsoluteLayout là loại layout mà các view (control) được quy định định chính xác vị trí và phạm vi hiển thị.
>Thuộc tính được đặt ở các control
+ AbsoluteLayout.LayoutBounds ="X,Y,Width,Height" - Xác định vị trí, phạm vi hiển thị tương đối hoặc tuyệt đối của control trên màn hình.
+ AbsoluteLayout.Flags = "(2)" - Xác định kiểu giá trị tương đối hoặc tuyệt đối của giá trị truyền vào tạo LayoutBounds.

Trong (2) có thể là:
+ None - Tất cả Tuyệt Đối.
+ All - Tất cả Tương đối.
+ XProportional - X Tương đối, còn lại Tuyệt Đối.
+ YProportional - Y Tương đối, còn lại Tuyệt Đối.
+ WidthProportional - Chiều rộng Tương đối, còn lại Tuyệt Đối.
+ HeightProportional - Chiều cao Tương đối, còn lại Tuyết Đối.
+ PositionProportional - X và Y Tương đối, rộng và cao Tuyệt Đối.
+ SizeProportional - Rộng và cao Tương đối, X và Y Tuyệt Đối.

*(Có thể dùng kết hợp các thuộc tính trong (2) cùng 1 lúc)*

## RelativeLayout
### RelativeLayout là loại layout mà các view (control) được xác định vị trí tương đối với nhau hoặc với control cha.
>Thuộc tính tại đặt tại các control
+ RelativeLayout.XConstraint="{ConstraintExpression (3)}" – Vị trí toạ độ X
+ RelativeLayout.YConstraint="{ConstraintExpression (3)}" – Vị trí toạ độ Y
+ RelativeLayout.WidthConstraint="{ConstraintExpression (3)}" – Chiều rộng của control
+ RelativeLayout.HeightConstraint="{ConstraintExpression (3)}" – Chiều cao của control

Trong (3) là các giá trị:
+ Type ="RelativeToParent/RelativeToView" - xác định kiểu ràng buộc

  *(RelativeToParent - Mối quan hệ layout và control. RelativeToView - Mối quan hệ control và control.)*
  
+ ElementName="" – Nếu như Type là kiểu RelativeToView thì cần phải cho biết tên control để tạo mối quan hệ, còn không thì bỏ qua giá trị này.
+ Property="" – Lựa chọn đặc tính trong các loại: X, Y, Width, Height.
+ Factor="" – Tăng hoặc giảm giá trị Property theo cấp số nhân (giảm khi nhân với những số trong khoảng 0 -> 1).
+ Constant="" – Tăng hoặc giảm giá trị Property theo cấp số cộng (giảm khi cộng với số âm).

