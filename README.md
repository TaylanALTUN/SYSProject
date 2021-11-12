# SYSProject

1- SYSProject.WebAPI / appsettings.json içinde DB ayarı gerekirse yapılır.


2- Package Manager Console "SYSProject.DataAccess" katmanı seçilerek açılır ve "EntityFrameworkCore\update-database" komutu çalıştırılır. Bu şekilde veri tabanı örnek datalarla oluşturulmuş olur. 


3- WebAPI projesi başlatma projesi olarak seçilerek program çalıştırlır.
4- SYSProject.WebAPI / Postman Collection dizinindeki json koleksiyon dosyası postman'e import edilerek endpoint testleri yapılabilir. Projenin çalıştığı url ne ise environment değişkeni olarak "baseUrl" bu değerle tanımlanır.
5- Login yapılıp token alınır.
6- Diğer tüm endpointler için login ile alınan jwt bearer token olarak kullanılır.

Db Migration için: 
PM Console > EntityFrameworkCore\Add-Migration Test
PM Console > EntityFrameworkCore\update-database
