# Images
## Image
### Image là control dùng để hiển thị hình ảnh
>Các thuộc tính quan trọng
+ x:Name="" liên kết với code behind
+ Source="" xác định dữ liệu nguồn của ảnh
+ Aspect="AspectFill/AspectFit/Fill" - các chế độ hiển thị của hình ảnh
  
  Trong đó:
  
  AspectFill - Hình ảnh sẽ hiển thị theo đúng kích thước ban đầu.
  
  AspectFit - Hình ảnh sẽ được hiển thị theo khung chứa nó đảm bảo chất lượng hình ảnh là tốt nhất.
            
  Fill - Hình ảnh sẽ bị kéo dãn/thu nhỏ hiển thị đầy đủ trong khung chứa.

## Gắn Source cho Image
### Downloaded Image
>Có 2 cách sử dụng Downloaded Image

 Cách 1: Sử dụng Xaml
 
+ Source = "Link url" dùng để lấy ảnh từ internet về ứng dụng.
  
 Cách 2: Sử dụng code behind 

```
//Gán trực tiếp
image.Source = "Link Url";

//Gán quá đối tượng UriImageSource
var imageSource = new UriImageSource { Uri = new Uri(Link Url) };
imageSource.CachingEnabled = false; //Bật tắt bộ nhớ đệm
imageSource.CahingValidity = TimeSpan.FromHours(1); //Thời gian lưu trữ 1 giờ
image.Source = imageSource;
```
### Nhúng 1 file bên ngoài project
### Thêm ảnh vào các thư mục Platform (drawable với Android, Resources với IOS)
## ActivityIndicator
### ActivityIndicator là một control co phép diễn tả một hành động đang diễn ra (đang tải ảnh, load dữ liệu trên list...)
>Thuộc tính quan trọng
 + Color thay đổi màu của control
 + IsRunning="{Binding Source={x:Reference (1)}, Path=(2)}" - ràng buộc với trạng thái của một control khác.
 
 *((1) là tên của control, (2) là thuộc tính hoặc giá trị ràng buộc).*
 
 >Cách dùng: ```<ActivityIndicator Color="Red" IsRunning="true" /> (nếu giá trị truyên vào IsRunning là true thì indicator sẽ hiển thị không dừng)```
### Dealling Size
### Application Icon
