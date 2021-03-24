using System;

public interface IWidget
{
    long Id { get; set; }
    DateTimeOffset Date { get; set; }
    string Name { get; set; }
    int Count { get; set; }
    string Secret { get; set; } // not included in DTO version of class.
    string Display(string title);
    int Ping(int x, int y);
}
