# BookLibrary
- Bu proje, bir kitaplık kütüphanesi uygulamasını yönetmek ve kitaplarla ilgili kategori, yayıncı,yaazar gibi bilgileri takip etmek amacıyla geliştirilmiştir.

## Kullanılan Teknolojiler

- ASP.NET Core: Projede ASP.NET Core kullanılmıştır. Web uygulaması, yapılandırma ve middleware yönetimi için ASP.NET Core kullanılmıştır.

- Dependency Injection: ASP.NET Core'un entegre ettiği dependency injection özelliği kullanılarak bağımlılıklar yönetilmiştir.

- Entity Framework Core: Veritabanı işlemleri için Entity Framework Core kullanılmıştır. Veritabanına bağlantı için SQL Server kullanılmıştır.

- Swagger/OpenAPI: API'lerin belgelenmesi ve test edilmesi amacıyla Swagger/OpenAPI kullanılmıştır.

- Generic Repository Pattern: Projede genel bir repository (depo) kalıbı uygulanmıştır. Bu, veritabanı işlemlerini soyutlamak ve genelleştirmek için yaygın olarak kullanılan bir tasarım desenidir.

- LINQ (Language-Integrated Query): LINQ ifadeleri, sorgulama işlemleri için kullanılmıştır. LINQ, C#'ın dil içi sorgu yetenekleri sağlayan güçlü bir özelliktir.

- Exception Handling: `BusinessException` sınıfı, iş mantığından kaynaklanan özel istisnaları yönetmek için kullanılmıştır.

- Autofac: Bu, bağımlılık enjeksiyonu için kullanılan bir üçüncü taraf konteynerdir. Autofac, .NET Core'un içindeki built-in DI (Dependency Injection) mekanizmasını geliştirir ve daha fazla özellik ekler. Projeye Autofac eklemek, bağımlılıklarınızın daha esnek bir şekilde yönetilmesini sağlar.

- FluentValidation: Bu, nesne doğrulama kurallarını tanımlamak ve uygulamak için kullanılan bir kütüphanedir. Özellikle giriş modeli doğrulaması için yaygın olarak kullanılır. FluentValidation sayesinde karmaşık doğrulama kuralları tanımlamak daha kolay ve okunabilir hale gelir.

- AOP (Aspect-Oriented Programming):AOP, bir uygulamadaki genel konuların kodun içine gömülmesini engelleyip, bunları ayrı bir yapı içinde ele alarak kodun daha temiz ve bakımı daha kolay hale gelmesini sağlar.
