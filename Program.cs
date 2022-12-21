using EM;

// important to know
// until 10/05/2011 max 9 for star
// until 24/09/2016 max 11 for star
// nowadays for max is 50 for numbers and 12 for stars
// any testing with stars before '16 is useless

var data = DataAccess.getDataCsv("Data/euromillions-gamedata-20040213-20221202.csv");
var dataStars = data.Where(x => x.Date > new DateTime(2016, 09, 25)).ToList();
foreach (var d in data)
{
    d.TurnIntoArrays();
}

Initialization.fiveNumber(data);
Initialization.twoStar(dataStars);

var threeNumbers = Initialization.threeNumber();

foreach (var series in threeNumbers)
{
    series.checkForResults(data);
    series.calculatePercentages(data.Count);
}

DataAccess.writeDataCsv(threeNumbers);
