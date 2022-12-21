using CsvHelper;
using CsvHelper.Configuration.Attributes;

public class CsvData
{
    public DateTime Date { get; set; }
    public byte n1 { get; set; }
    public byte n2 { get; set; }
    public byte n3 { get; set; }
    public byte n4 { get; set; }
    public byte n5 { get; set; }
    public byte s1 { get; set; }
    public byte s2 { get; set; }
    [Ignore]
    public byte[] Numbers { get; set; } = new byte[5];
    [Ignore]
    public byte[] Stars { get; set; } = new byte[2];

    public void TurnIntoArrays()
    {
        Numbers[0] = n1;
        Numbers[1] = n2;
        Numbers[2] = n3;
        Numbers[3] = n4;
        Numbers[4] = n5;
        Stars[0] = s1;
        Stars[1] = s2;
    }
}