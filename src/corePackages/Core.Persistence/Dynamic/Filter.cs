namespace Core.Persistence.Dynamic;

public class Filter
{
    public string Field { get; set; } //Hangi alana göre filtreleme yapılacak
    public string Operator { get; set; } //Filtreleme operatörü
    public string? Value { get; set; } //Filtreleme değeri
    public string? Logic { get; set; } //Filtreleme mantıksal bağlacı
    public IEnumerable<Filter>? Filters { get; set; }

    public Filter()
    {
    }

    public Filter(string field, string @operator, string? value, string? logic, IEnumerable<Filter>? filters) : this()
    {
        Field = field;
        Operator = @operator;
        Value = value;
        Logic = logic;
        Filters = filters;
    }
}