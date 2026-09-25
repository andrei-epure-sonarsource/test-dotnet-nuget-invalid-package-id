using Newtonsoft.Json;

var invoices = new[]
{
    new Invoice("INV-100", 125.50m),
    new Invoice("INV-101", 74.50m)
};

var summary = new InvoiceSummary(invoices.Length, invoices.Sum(x => x.Amount));
Console.WriteLine(JsonConvert.SerializeObject(summary));

internal sealed record Invoice(string Number, decimal Amount);

internal sealed record InvoiceSummary(int Count, decimal Total);
