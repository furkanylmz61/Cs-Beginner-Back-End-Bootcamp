namespace basics.Models;

public class Repository
{
    private static readonly List<Bootcamp>
        _bootcamps = new(); // _bootcamps adında statik ve özel bir liste tanımlıyoruz.
    // Bu liste Bootcamp türünde nesneler içerir.
    // "readonly" anahtar kelimesi bu listenin yalnızca sınıf oluşturulurken veya constructor içinde değiştirilebileceğini belirtir.

    static Repository(){
        _bootcamps = new List<Bootcamp>(){
            new Bootcamp() {id = 1,Title = "Beginner Back-end Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "1.jpeg"},
            new Bootcamp() {id = 2,Title = "Full Stack Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "2.png"},
            new Bootcamp() {id = 3,Title = "Game Bootcamp", Description = "2 Ocak'ta başiladık. 20 kişi ile başladık.", Image = "3.png"},
        };
    }// bu alanda nesneleri ekliyoruz

    public static List<Bootcamp> Bootcamps{
        get{
            return _bootcamps;
        }
    }//Bootcamps adında genel bir özellik tanımlanıyor. Bu özellik, _bootcamps listesini döndürür.
     //Sadece get erişimine sahiptir, bu da listenin dışarıdan değiştirilemeyeceği anlamına gelir.

    public static Bootcamp? GetById(int id){
        return _bootcamps.FirstOrDefault(b=>b.id == id);
    }// GetById adında bir genel (public) statik yöntem tanımlanıyor.
     // Bu yöntem, bir id parametresi alır ve belirtilen id'ye sahip bir Bootcamp nesnesi döndürür.
     // _bootcamps listesindeki nesneler arasında id'si parametre ile eşleşen ilk nesneyi döndürür.
     // Eğer eşleşen bir nesne bulunamazsa, null döner.
}
