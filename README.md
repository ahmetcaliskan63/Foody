# Foody - Yemek Sipariş Sistemi

## Proje Hakkında
Foody, modern ve kullanıcı dostu bir yemek sipariş sistemidir. ASP.NET Core MVC kullanılarak geliştirilmiş olup, katmanlı mimari (N-Tier Architecture) prensiplerine uygun olarak tasarlanmıştır.

## Teknolojiler
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 
- HTML5/CSS3 
- JavaScript/jQuery

## Proje Yapısı
Proje, aşağıdaki katmanlardan oluşmaktadır:

### 1. Presentation Layer (Foody.PresentationLayer)
- Kullanıcı arayüzü
- Controller'lar
- View'lar
- Client-side scriptler

### 2. Business Layer (Foody.BusinessLayer)
- İş mantığı
- Servis katmanı
- Manager sınıfları
- Validasyonlar

### 3. Data Access Layer (Foody.DataAccsessLayer)
- Veritabanı işlemleri
- Repository pattern implementasyonu
- Entity Framework Core konfigürasyonları

### 4. Entity Layer (Foody.EntityLayer)
- Veritabanı modelleri
- Entity sınıfları
- DTO'lar

## Özellikler
- Kullanıcı Yönetimi
  - Kayıt olma
  - Giriş yapma
  - Profil yönetimi
- Ürün Yönetimi
  - Ürün ekleme/düzenleme/silme
  - Kategori bazlı ürün listeleme
  - Stok takibi
- Sipariş Yönetimi
  - Sipariş oluşturma
  - Sipariş takibi
  - Sipariş geçmişi
- Yorum ve Değerlendirme Sistemi
- Adres Yönetimi
- Sosyal Medya Entegrasyonu

## Kurulum
1. Projeyi klonlayın
```bash
git clone https://github.com/kullaniciadi/Foody.git
```

2. Veritabanını oluşturun
```bash
Update-Database
```

3. Projeyi çalıştırın
```bash
dotnet run
```

## Katkıda Bulunma
1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeniOzellik`)
5. Pull Request oluşturun

## Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## İletişim
- Proje Sahibi: [İsim Soyisim]
- E-posta: [E-posta Adresi]
- LinkedIn: [LinkedIn Profili]

## Teşekkürler
- Tüm katkıda bulunanlara
- Açık kaynak topluluğuna
- Kullanılan tüm kütüphanelerin geliştiricilerine
