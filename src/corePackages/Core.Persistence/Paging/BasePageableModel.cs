namespace Core.Persistence.Paging;

public class BasePageableModel
{
    public int Index { get; set; } //Kaçıncı sayfa olduğunu belirtir.
    public int Size { get; set; } //Her sayfada kaç adet veri olacağını belirtir.
    public int Count { get; set; } //Toplam veri sayısını belirtir.
    public int Pages { get; set; } //Toplam sayfa sayısını belirtir.
    public bool HasPrevious { get; set; } //Önceki sayfa olup olmadığını belirtir.
    public bool HasNext { get; set; } //Sonraki sayfa olup olmadığını belirtir.
}