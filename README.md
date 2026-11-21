# Plaka Kayıt Uygulaması

Windows Forms ve SQL Server LocalDB kullanılarak geliştirilmiş basit bir plaka-şehir kayıt uygulamasıdır. Uygulama, şehir ve plaka bilgilerini `DataGridView` üzerinde listelemek için kullanılır.

## Özellikler

- SQL Server LocalDB bağlantısı
- `Sehirler` tablosundaki kayıtları listeleme
- Plaka ve şehir bilgileri için giriş alanları
- Windows Forms arayüzü

## Gereksinimler

- Windows
- Visual Studio 2022 veya daha yeni bir sürüm
- .NET 10 SDK
- SQL Server Express LocalDB

## Projeyi Çalıştırma

1. Repoyu klonlayın veya projeyi indirin.

   ```bash
   git clone <REPO_URL>
   cd PlakaKayıtUygulamasi
   ```

2. `PlakaKayıtUygulamasi.slnx` veya `PlakaKayıtUygulamasi.csproj` dosyasını Visual Studio ile açın.

3. `Database1.mdf` dosyasının proje içinde bulunduğunu kontrol edin.

4. Projeyi derleyin ve çalıştırın.

5. Uygulamada **Listele** butonuna basarak kayıtları `DataGridView` üzerinde görüntüleyin.

## Veritabanı Bağlantısı

Uygulama SQL Server LocalDB kullanır. Bağlantı `Form1.cs` dosyasında tanımlıdır:

```csharp
Data Source=(LocalDB)\\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\\Database1.mdf;
Integrated Security=True
```

`Database1.mdf` ve `Database1_log.ldf` dosyalarının derleme çıktısına kopyalanması proje dosyasında yapılandırılmıştır.

## Veritabanı Tablosu

Listeleme işlemi aşağıdaki tabloyu kullanır:

```sql
SELECT * FROM Sehirler;
```

Tablonun mevcut olmadığını belirten bir hata alırsanız, LocalDB içindeki MDF dosyasının doğru dosya olduğunu ve `Sehirler` tablosunun bulunduğunu kontrol edin.

## Sorun Giderme

### `SehirlerDB.mdf` bulunamadı veya eklenemedi hatası

Hata mesajında eski `SehirlerDB.mdf` yolu görünüyorsa eski derleme çıktısı çalışıyor olabilir:

1. Uygulamayı ve Visual Studio'yu kapatın.
2. Projedeki `bin` ve `obj` klasörlerini silin.
3. Visual Studio'yu yeniden açın.
4. **Clean Solution** ve ardından **Rebuild Solution** çalıştırın.

### Aynı isimli veritabanı zaten var hatası

LocalDB içinde aynı veritabanı daha önce eklenmiş olabilir. SQL Server Object Explorer üzerinden eski bağlantıyı ayırın veya LocalDB örneğini yeniden başlatın. Daha sonra projeyi yeniden derleyin.

## Proje Yapısı

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
