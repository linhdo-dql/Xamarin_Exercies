# Những thứ cần thiết trong Xamarin
## Databinding
### Databinding là kĩ thuật dùng để ràng buộc dữ liệu giữa các control trong cùng layout, control với dữ liệu bên ngoài layout. Khi dữ liệu được ràng buộc thay đổi thì nơi ràng buộc dữ liệu cũng có sự thay đổi tùy thuộc vào thuộc tính bị ràng buộc. Nguồn có thể là thuộc tính của một control khác, một đối tượng, một mảng....

>Có 2 cách sử dụng Databinding trên Xaml file:

 **Cách 1**: Sử dụng BindingContext
 * BindingContext="x:Reference <Name của control ràng buộc>" là thuộc tính của một control dùng để truyền Name của một control khác để thiết lập ràng buộc. 
 (control được gắn thuộc tính này là đích, Name được truyền là nguồn).
 * BindingMode="Default|OneWay|OneWayToSource|TwoWay|OneTime" là thuộc tính quy định kiểu ràng buộc.
    + Default: 
    + OneWay: Các giá trị được chuyển từ nguồn sang đích
    + OneWayToSource: Các giá trị được chuyển từ đích sang nguồn
    + TwoWay: Các giá trị được truyền qua lại giữa đích và nguồn
    + OneTime: Dữ liệu được truyền từ nguồn sang đích chỉ khi nào có sự thay đổi của dữ liệu nguồn   
    
 **Cách 2**: Sử dụng Thuộc tính Source="{x:Reference <x:Name của control ràng buộc>}" ngay tại nơi xuất hiện ràng buộc. Source quy định nguồn của giá trị truyền vào.
 >Cách ràng buộc: 
 Tại nơi có giá trị cần ràng buộc gán giá trị bằng cú pháp "{Binding (1)}"
 
 Nội dung trong (1) có thể là:
 
 Cặp giá trị:
 + Source = "{x: Reference <x:Name>}" đã nói ở trên
 + Path="<Thuộc tính> hoặc Value" chứa giá trị cuart huộc tính truyền vào
 
 Hoặc:
 + Tên thuộc tính - việc truyền thuộc tính mặc định giá trị truyền vào là giá trị của thuộc tính tại control ràng buộc
 + Mode="" - với những control có nhiều chế độ, chế độ được quy định sẽ được truyền giá trị.
 + Converter="" - dùng để convert kiểu dữ liệu của giá trị truyền vào sang kiểu dữ liệu khác
 + StringFormat="" - Giống C# (với các thuộc tính hiển thị Text của control).
 
 (Các thuộc tính này cũng có thể gọi tại code behind bằng c# syntax);
 
 ## OnPlatform
 
 ### OnPlatform quy định cách thức hoạt động, các hiển thị của page trên từng nền tảng.(IOS, Android, Window Phone...).
 
 >Sử dụng OnPlatform trên xaml
 
 * x:TypeArguments quy định kiểu của tham số truyền vào.
 
 Nội dung trong cặp thẻ <OnPlatform></OnPlatform> là các dòng lệnh tương ứng cho từng nền tảng: <Nền tảng>="(1)". Tùy thuộc vào TypeAguament mà (1) là các loại giá trị khác nhau.
 
 >Sử dung OnPlatform trên code behind
 
 var x = new OnPlatform<Kiểu tham số> { <Nền tảng>="<Giá tri>",...};
 
 Giá trị của x sẽ được truyền vào thuộc tính có kiểu tham số phù hợp.
 
 ### Cú pháp viết Xaml
 
 ### Liên kết giữa code behind và xaml
 
 
 
