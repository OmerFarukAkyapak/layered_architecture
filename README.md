# MSE intern workspace
*include layered architecture researches*

## GIT Versiyon Kontrol
- Bir dosya veya bir küme dosyadaki değişiklikleri takip edebilmek için uyguladığımız bir yöntem olarak tanımlayabiliriz.
- Git gibi sistemler tüm bu değişikliklerin tarihçesini ve içeriğini elektronik olarak bizim için takip ederek kayıt altına almamızı sağlayan veri tabanları olarak düşünülebilir.

## SOLID
- SOLID yazılım prensipleri; geliştirilen yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür.

- S — Single-Responsibility Principle
  - Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.
- O — Open-Closed Principle
  - Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.
- L — Liskov Substitution Principle
  - Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.
- I — Interface Segregation Principle
  - Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.
- D — Dependency Inversion Principle
  - Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
 
## DRY
- Dont repeat yourself! DRY prensibi kodun tekrarlanmasına (code duplication) düşmandır.
- Aynı işi yapan kodların (genellikle kopyala-yapıştır ile) ihtiyaç duyulduğu her yerde tekrarlanarak projenin çöp olması; yönetilebilirlik, haliyle geliştirilebilirlik ve sürdürülebilirlik imkanlarından gittikçe uzaklaşmasını engellemeye odaklanır.
- Eğer daha önce yazılmış bir kod ya da kod bloğunu tekrar kullanmaya ihtiyacımız olursa; mevcut kodu bir fonksiyona/sınıfa/metoda dönüştürerek (mümkünse refactor ederek) eski kullanan yeri bu noktaya bağlayıp, sonrasında yeni yazacağımız kodlarda da bu merkezileştirdiğimiz nokta üzerinden kullanmalıyız.

## API
- Application Programming Interface, bir uygulamanın işlevlerine dışarıdan veya uzaktan erişilip bu işlevlerin kullanılmasını sağlayan arayüzdür.
- API, iki uygulamanın birbiriyle iletişime geçmesini sağlayan bir yazılım aracıdır da diyebiliriz.
- API herhangi bir sunucunun response dönmesine ve sunucunun üzerindeki uygulamaya farklı platformlardan ulaşılmasına olanak sağlar, platform bağımsızdır.

## BACKEND
- Backend, kullanıcıların görmediği arka yüz (Server-side) geliştiren kişidir. Yani sistemin mimarisini oluşturan, veri tabanı yönetimini planlayan, sunucu ayarlamalarından sorumlu, sistemin maksimum seviyede verimli ve hızlı çalışmasını sağlayan kişidir.
- Backend programcıları, sunucu tarafında uygulamanın iş mantığını, veri tabanını ve diğer önemli işlevleri geliştirir.
- Kullanıcı arayüzü ile doğrudan etkileşime girmezler, ancak uygulamanın temel işlevselliğini ve veri yönetimini sağlarlar.

## BACKEND MİMARİ
- Bussiness : Yazılım iş kurallarının bulunduğu katmandır. Proje içerisinde gerçekleştirilecek işlem, fonksiyonların bulunduğu kaymandır.
- Core : Proje bazlı değişmeyen, her projeye uyarlanabilir tool, extension gibi nesnelerin ve DataAccess ve Entities katmanlarına bağlı sabit olan framework ve concreteleri barındıran katmandır.
- DataAccess : Projede bussiness ve entity katmanı arasında veri akışını sağlayan katmandır.
- Entities : Projede kullanılacak nesnelerin tutulduğu katmandır.
- WebAPI : Projenin veri tabanı üzerinde işlemleri gerçekleştiren katmandır. Bu işlemler sonucunda oluşan state değişikliklerinin görüntülenmesi ve crud işlemlerinin yapılabildiği katmandır. 
