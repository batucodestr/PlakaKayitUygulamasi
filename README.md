# Plaka Kayıt Uygulaması

## Proje Hakkında

Plaka Kayıt Uygulaması, şehirlerin plaka kodlarını kaydetmek ve kayıtlı şehir-plaka bilgilerini görüntülemek amacıyla geliştirilmiş bir masaüstü uygulamasıdır.

Uygulama Windows Forms arayüzü kullanır ve verileri SQL Server LocalDB üzerinde bulunan `Database1.mdf` veritabanı dosyasından okur. Kullanıcı **Listele** butonuna bastığında `Sehirler` tablosundaki kayıtlar alınarak `DataGridView` kontrolünde gösterilir.

Bu proje, C# ile Windows Forms uygulaması geliştirme, SQL bağlantısı kurma, veritabanından veri çekme ve çekilen verileri tablo şeklinde görüntüleme konularını uygulamalı olarak göstermektedir.

## Kullanılan Teknolojiler

- C#
- .NET 10 Windows Forms
- Microsoft.Data.SqlClient
- SQL Server Express LocalDB
- SQL Server MDF veritabanı
- DataGridView

## Uygulamanın Çalışma Mantığı

1. Uygulama açıldığında `Form1` oluşturulur.
2. `Form1.cs` içinde tanımlanan SQL bağlantısı `Database1.mdf` dosyasını hedefler.
3. Kullanıcı **Listele** butonuna basar.
4. `btnListele_Click` metodu çalışır.
5. `Sehirler` tablosu için aşağıdaki sorgu çalıştırılır:

   ```sql
   SELECT * FROM Sehirler;
   ```

6. Sorgudan dönen kayıtlar `DataTable` içine alınır.
7. `DataTable`, `dgvSehirler.DataSource` özelliğine atanır.
8. Kayıtlar form üzerindeki `DataGridView` kontrolünde görüntülenir.

## Arayüz

Form üzerinde şu kontroller bulunmaktadır:

- **Plaka** metin kutusu: Plaka kodu girişi için hazırlanmıştır.
- **Şehir** metin kutusu: Şehir adı girişi için hazırlanmıştır.
- **Ekle** butonu: Yeni kayıt ekleme işlemi için arayüzde bulunmaktadır.
- **Sil** butonu: Kayıt silme işlemi için arayüzde bulunmaktadır.
- **Güncelle** butonu: Kayıt güncelleme işlemi için arayüzde bulunmaktadır.
- **Listele** butonu: Veritabanındaki kayıtları listeler.
- **DataGridView**: Şehir ve plaka kayıtlarını tablo halinde gösterir.

Mevcut uygulama akışında çalışan temel işlem, `Listele` butonu ile kayıtların görüntülenmesidir. Ekleme, silme ve güncelleme işlemleri için arayüz kontrolleri hazırlanmış olup bu işlemlere ait veritabanı kodları ayrıca eklenebilir.

## Veritabanı

Proje, SQL Server LocalDB ile birlikte gelen MDF veritabanı dosyasını kullanır. Veritabanı dosyaları şunlardır:

- `Database1.mdf`: Verilerin bulunduğu ana veritabanı dosyası.
- `Database1_log.ldf`: Veritabanının işlem günlük dosyası.

Uygulamanın kullandığı tablo `Sehirler` tablosudur. Listeleme işlemi bu tablodaki tüm kayıtları getirir.

Bağlantı, `Form1.cs` içerisinde aşağıdaki yapı ile sağlanır:

```csharp
Data Source=(LocalDB)\\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\\Database1.mdf;
Integrated Security=True
```

MDF ve LDF dosyalarının derleme çıktısına kopyalanması proje dosyasında yapılandırılmıştır.

## Proje Dosyaları

```text
PlakaKayıtUygulamasi/
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── Database1.mdf
├── Database1_log.ldf
└── PlakaKayıtUygulamasi.csproj
```

### Dosyaların Görevleri

- `Program.cs`: Uygulamanın başlangıç noktasıdır ve ana formu çalıştırır.
- `Form1.cs`: Veritabanı bağlantısını ve **Listele** butonunun çalışma kodunu içerir.
- `Form1.Designer.cs`: Form üzerindeki buton, metin kutusu, etiket ve `DataGridView` kontrollerinin tasarım kodunu içerir.
- `Form1.resx`: Formun kaynak bilgilerini içerir.
- `Database1.mdf`: Uygulamanın kullandığı SQL Server LocalDB veritabanıdır.
- `Database1_log.ldf`: SQL Server işlem günlük dosyasıdır.
- `PlakaKayıtUygulamasi.csproj`: .NET hedefini, Windows Forms ayarlarını, `Microsoft.Data.SqlClient` paketini ve veritabanı dosyalarının kopyalanma ayarlarını içerir.

## Projenin Amacı

Bu proje, masaüstü uygulaması ile veritabanı arasındaki temel iletişimi göstermek için hazırlanmıştır. Kullanıcı arayüzündeki bir buton aracılığıyla SQL sorgusu çalıştırılır, sonuçlar bellekteki `DataTable` nesnesine aktarılır ve son olarak tablo biçiminde kullanıcıya sunulur.
