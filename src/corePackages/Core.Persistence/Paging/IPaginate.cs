namespace Core.Persistence.Paging;

public interface IPaginate<T>
{
    int From { get; } //Hangi imlecin başladı
    int Index { get; } //Hangi sayfada olduğumuz
    int Size { get; } //Her sayfada kaç kayıt olacak
    int Count { get; } //Toplam kaç kayıt var
    int Pages { get; } //Toplam kaç sayfa var
    IList<T> Items { get; } //Sayfada bulunan kayıtlar
    bool HasPrevious { get; } //Önceki sayfa var mı
    bool HasNext { get; } //Sonraki sayfa var mı
}