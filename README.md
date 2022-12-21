## About the project
Euromillions is a lottery playable in several European countries. This project is to check which number of series are most profitable to use to increase profits. At start the output file should have been an excel file for my dad (because he doesn't know sql), but sql was needed for series of 5 numbers because there weren't enough rows for one excel sheet.

## Built with 
- [![Dotnet][.net]][Dotnet-url]
- [![LibreOffice][LibreOffice]][LibreOffice-url]
- [![SQL][SQLite]][SQLite-url]


[Dotnet-url]: https://dotnet.microsoft.com/en-us/
[LibreOffice-url]: https://www.libreoffice.org/
[SQLite-url]: https://www.sqlite.org/index.html

[.net]: https://img.shields.io/badge/.NET6-20232A?style=for-the-badge&logo=.net&logoColor=61DAFB
[LibreOffice]: https://img.shields.io/badge/LibreOffice_Calc-11ac12?style=for-the-badge
[SQLite]: https://img.shields.io/badge/SQLite-0769AD?style=for-the-badge&logo=sql&logoColor=white

## Results

![Results For Five Numbers](/Images/ResultsFiveNumbers.png)


![Results For Four Numbers](/Images/ResultsFourNumbers.png)

### Explanation
### Explanation
- Numbers column are selected main numbers
- Following columns says how many times (percentage wise) a number in that series have been hit over all the euromillions results. For example the series `[10, 12, 23, 37, 44]` has a chance of 32.913% to have at least one number in the series to be in a Euromillions Results. There's a chance of 9.773% of at least two numbers to be hit in the series
- Picture has the top results, but most of the possible series have a chance of 4-6% to have at least 2 numbers right in the end results
- The excel picture are the results for series of 4 numbers ordered for two hits percentage

## Learned from this project
- CSV is saved in xml format
- There's a max amount of rows for csv and xlsx projects (1,048,576 rows)
- Clone values to not use reference values

## Possible improvements and new features
- At present writing away the data in excel happens through generic functions. Try to make sql functions as generic possible.
- Check how many days since a number has been drawn and check for all results what's the average wait to draw a number
- refactor code to remove warnings vscode/.NET gives