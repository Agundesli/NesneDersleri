Nesne yönelimli programlamanın ilk prensibi kapsülleme (encapsulation) olarak adlandırılır. 
Bu özellik, dilin nesne kullanıcısından gereksiz uygulama ayrıntılarını saklar. 
Oluşturulan bir sınıf içerisinde kullanıcının işlemlerini daha kolay gerçekleştirebilmesi için bazı işlemler 
birleştirilerek tek bir işlem gibi gösterilir. Bu birleştirme işlemine kapsülleme denir.

Erişim belirteçleri (access modifier) sayesinde kapsülleme çok daha kolay yapılmaktadır. 
Erişim belirteçleri, oluşturulan sınıf veya sınıf içindeki elemanların erişim seviyelerini belirlemek için kullanılan 
anahtar kelimeler grubuna verilen isimdir. 
Metotlar ve değişkenler bir anahtar sözcük ile önceden bellirlenen sınırlar dahilinde kullanılabilir. 
Bu anahtar kelimeler şu şekilde sıralanabilir.

public: Sistemdeki bütün sınıfların erişebilmesini sağlar. Yalnızca aynı proje içinden değil, diğer projelerden de erişim sağlanabilir.

private: Bir "özellik (property)"in veya "metod"un sadece tanımlandığı sınıftan erişilebilmesini sağlar. 
Oluşturulan sınıf veya yapıların "public" olması açık bir şekilde belirtilmez ise, derleyici tarafından "private" olarak belirlenir.

internal: Aynı derleyici (assembly) içinde bulunan tüm sınıflardan erişim sağlanır. 

protected: Sadece tanımlandığı sınıfın içinde ve o sınıftan türetilmiş diğer sınıfların içinde erişilebilir.

Kapsülleme "private" değişkenlerin metotlar gibi kullanılmasına yardımcı olur. Okuma (Read Only) işleminin yanısıra 
okuma - yazma (read - write) işleminin yapılmasını sağlar.