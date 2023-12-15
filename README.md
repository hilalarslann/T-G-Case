# T&G-Case
Case study listing products by category. Developed with ASP.Net API, ASP.Net MVC, JQuery.

1-Server name will be updated from appsettings.json in MiniETrade.Service

2-MiniETrade.Service - Set as Startup Project

3-From the Tools tab NuGet Package Manager from Package Manager Console
a-Default project-MiniETrade.Dal
b-Update-Database

4-After running the project right click on MiniETrade.UI
a-Debug - Start New Instance

<img src="https://user-images.githubusercontent.com/107270736/216539851-bdaa5559-2a6a-4d16-9c93-6052c4d5a00c.png"></img>


o How you make a JS async call to an URL within the same application handled by a
backend controller
-In my example it uses the $.ajax method from jQuery to perform a GET request to the specified URL.
The success function is called with the response data if the request is successful, and the error function with an error if the request fails.
With asynchronous programming, the request is made in the background, allowing the user to continue interacting with the page while the request is in progress.

o How you’ve structured your solution from a N-Layer perspective
Entities Layer & Dal Layer: First, I created my required entities in the Entity layer.
Then I came to the Dal layer and created Context and connected it to the database with Entity framework.
I associated the tables and classes in the database with dbset
Core Layer: I performed basic Crud operations in the Core layer
Repository Layer:Repository Layer is abstracting the data access layer and providing a more flexible and maintainable design for database interactions in software applications.
Unit of work Layer:I keep all the operations to be done with the database via interfaces in a unit of work class.
In this way, I ensure that transactions are performed in batches and can be rolled back in case of error.
Service Layer:Service layer, UI layer and data access layer.It provides an abstraction layer between
Presentation-UI Layer:This is the layer the user interacts with. The layer where I code the UI and user input

The reason I use a layered architecture is because it provides a software development framework that helps build maintainable, testable, scalable and reusable applications.

o How your data model is implemented (USE CODE-FIRST approach if possible)
After I create my classes and make the associations, I add migration, edit if there is any place that needs to be edited in the migration and update my database.
















Web api güvenlik açıklarını kapatmak için ne yaparız ?
Kullanıcıları doğrulamak ve yetkilendirmek için Authentication ve Authorization işlemleri yapılmalıdır.  Örnek olarak JWT (JSON Web Token , OpenID Connect gibi Kullanıcının kimliğini doğrulamak yöntemleri kullanabiliriz.
API kullanımını kontrol etmek ve kötü niyetli kullanımları önlemek için rate limiting (sorgu sıklığı kontrolü) uygulayın.Örneğin, 1 dakika içinde bir IP adresinden sadece 100 talep kabul etme.
Her başarılı talepten sonra refresh time belirlenir ve bu süre içinde yeni bir talep gönderilemez.

.Net Core – Framework arasındaki fark ?
 .NET Framework: Windows işletim sistemi üzerinde çalışan ve öncelikle masaüstü ve sunucu uygulamaları için tasarlanmıştır.
.NET Core: Çeşitli platformlarda çalışabilen, özellikle cross-platform (çoklu platform) ve bulut tabanlı uygulamalar geliştirmek amacıyla tasarlanmıştır. Linux ve macOS gibi işletim sistemlerinde de desteklenir.
Masaüstü uygulamaları, sunucu uygulamaları, web uygulamaları ve hizmetler gibi çeşitli uygulama türlerini destekler.
Web uygulamaları, mikro servisler, bulut tabanlı uygulamalar ve çapraz platform uygulamalar gibi modern ve hafif uygulama türlerine odaklanmıştır.

DBFirst – CodeFirst arasındaki farklar ?
DB-First yaklaşımında, başlangıç noktası mevcut bir veritabanıdır. Var olan bir veritabanı şemasına dayanarak modeller ve sınıflar oluşturulur.
Code-First yaklaşımında, ise kod tarafında gerekli tablolara karşılık gelecek enititylerimizi oluşturur migration ile veritabanımızı oluştururuz. Veritabanındaki değişiklikleri kod üzerinden yönetmemizi sağlar.

Entityframework nedir ?
Entity Framework, Microsoft tarafından geliştirilen ve .NET platformu üzerinde veritabanı işlemlerini kolaylaştırmak için kullanılan bir ORM framework’dür.
DbContext: Veritabanı bağlantısını temsil eder.
DbSet: DbSet<T> sınıfları, bir DbContext içinde belirli bir sınıfa karşılık gelen bir veritabanı tablosunu temsil eder.
DbSet<T> sınıfları, DbContext içindeki tablolara erişim sağlamak ve bu tablolarda sorgular yapabilmek için kullanılır. 

MVC’de middleware nedir ?
HTTP istekleri üzerinde işlem yapma, güvenlik kontrolleri, günlük tutma, önbelleğe alma, sıkıştırma gibi işlemleri gerçekleştiren bileşenlerdir. 
Request ile response arasında işlem yapıyorsak, örnek kitap listesini çekmek için bir request geldi, kullanıcı kimlik kontrolü için authentication yaparız. Bir başka middleware de Authorization yaparız.
Middleware, IApplicationBuilder sınıfındaki Use metodunu kullanarak eklenir. Middleware'ler, eklenme sırasına göre çalışır ve bir talebin işlenmesi için bir zincir oluştururlar.Örnek ilk middleware tetiklendi ikinci tetiklendiğinde ilki sonlanmaz sarmal şekilde çalışılır.

Viewmodel nedir?
Viewmodel, view de kullanılan dataları taşıyan onu temsil eden bir sınıf.

DTO nedir?
DTO nesnesi genellikle SQL den gelen dataların backend içindeki herhangi bir noktadan başka bir noktaya sadece kullanılacak olan datalarını temsil eden bir nesnedir.

Dependency Injection nedir?
Bağımlılık oluşturan parçaların ayrılıp, bunların constructor dan verilmesiyle sistem içerisindeki bağımlılığı minimize eder

SOLID Yazılım mühendisliğinde SOLID, nesne yönelimli tasarımları daha anlaşılır, esnek ve sürdürülebilir kılmayı amaçlayan beş tasarım ilkesinin anımsatıcı bir kısaltmasıdır
 Single-responsibility principle(prınsıpl) "Bir sınıfın değişmesi için asla birden fazla neden olmamalıdır." Başka bir deyişle, her sınıfın yalnızca bir sorumluluğu olmalıdır. 
 Open–closed principle "Yazılım varlıkları ... genişletmeye açık olmalı, ancak değişiklik için kapalı olmalıdır."-Sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
 Liskov substitution(sabstitişın) principle "Temel sınıflara işaretçiler veya referanslar kullanan işlevler, türetilmiş sınıfların nesnelerini bilmeden kullanabilmelidir."
 Interface segregation(segıregeyşın) principle "Birçok müşteriye özel interface, tek bir genel amaçlı interface den daha iyidir."-Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.
 Dependency inversion principle  "Somutlamalara değil, soyutlamalara bağlıdır . ".

 
9-  	TSQL ve MSSQL arasındaki fark nedir ?
T-SQL, SQL Server üzerinde kullanılan özel bir sorgu dilidir, MSSQL ise Microsoft SQL Server'ın kendisini ifade eder. 

10- Microservislerin mantığı nedir ?
Microservis mimarisi, büyük bir yazılım uygulamasını küçük parçalara böler.
Her parça (microservis), kendi başına çalışan ve belirli bir işlevi yerine getiren bir hizmettir. Bu parçalar birbirleriyle iletişim kurar, ancak bir hizmetin çökmesi diğerlerini etkilemez.

11- ASP.Net api ile mvc arasındaki fark nedir ?
ASP.NET MVC: Web uygulamaları geliştirmek için tasarlanmıştır.İstemci ve sunucu arasında veri alışverişi üzerine odaklanır.
ASP.NET API (Web API): Genellikle, uygulamalar arası veri alışverişi için tasarlanmıştır. RESTful servisler sağlamak veya mobil uygulamalar gibi farklı istemcilerle veri paylaşımı amacıyla kullanılır

12- Restful servis nedir ?
RESTful servis, temel olarak web tabanlı uygulamalarda veri alışverişi sağlayan bir tür web servisidir. 

12-Fluent API nedir
 Fluent API kullanarak bir Entity Framework modeline özellik eklemek için kullanılır.Kodu daha açık, sade ve doğru bir şekilde ifade etmeye odaklanır.
 
13-Asenkron yapı nedir ?
Senkron programlama modelinde, bir işlemin başlamasından önce bir önceki işlemin tamamlanması gerekmektedir.
Asenkron, işlemlerin birbirinden bağımsız olarak ve aynı anda gerçekleşebildiği bir durumu ifade eder.

