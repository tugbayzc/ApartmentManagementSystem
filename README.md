# ApartmentManagementSystem
Admin yetkilendirmesi için Jwt Token kullanıldı.Swaggera entegre edildi.

Diğer kullanıcılar sadece kullanıcı işlemlerini(mesaj gönderme ve fatura bilgilerine ulaşma) gerçekleştirebilirler, admine özel işlemler için yetki verilmedi.

Adminin token alması için Autherize Endpointinde girmesi gereken bilgiler: username= admin , password= ty123

Api Controller da Admin ve Basic kullanıcı için iki farklı controller yazıldı. Admin Controller da her bir Authorize Endpointe erişim tokenla sağlandı.

Api de eklenen,güncellenen,silinen veriler Mssql de CodeFirst yaklaşımıyla oluşturulan ApartmentDb veri tabanına gönderiliyor ve saklanıyor.

Kullanıcılara otomatik şifre atama, girişlerini sağlama ve faturasını ödemeyenlere günlük mail job atma adımı uygulanamadı.

Proje geliştirilmeye devam edilecek. 
