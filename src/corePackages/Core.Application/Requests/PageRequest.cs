namespace Core.Application.Requests;

public class PageRequest
{
    public int Page { get; set; } //Kaçıncı sayfa isteniyor
    public int PageSize { get; set; } //Sayfa başına kaç kayıt olsun
}