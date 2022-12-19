# ApartmentManagementSystem
Admin yetkilendirmesi için Jwt Token kullanıldı.Swaggera entegre edildi.

Diğer kullanıcılar sadece kullanıcı işlemlerini(mesaj gönderme ve fatura bilgilerine ulaşma) gerçekleştirebiliyor, admine özel işlemler için yetkileri yok.

Adminin token alması için Autherize Endpointinde girmesi gereken bilgiler: username= admin , password= ty123

Api Controller da Admin ve Basic kullanıcı için iki farklı controller yazıldı. Admin Controller da her bir Endpointe erişim tokenla sağlanıyor.

Api de eklenen,güncellenen,silinen veriler Mssql de CodeFirst yaklaşımıyla oluşturulan ApartmentDb veri tabanına gönderiliyor ve saklanıyor.
