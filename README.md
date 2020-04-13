# TEDStats-cli

TEDStats-cli is a cross-platform, open source command line tool to get statistics about EU public procurement from the [TED web site](https://ted.europa.eu).
Given a search query and a date period, it will determine how many notices match the query for each daily edition in that period. The results are written in a CSV file

It is written in C#, and runs on .NET Core 3.1.

## Usage

From the folder that contains this project:

```shell
dotnet run -- --query "FT=[COVID-19]" --from 2020-02-01 --to 2020-03-31
```

This will create a CVS file named `output.csv` with the number of notices that mention "covid-19" for each day in February and March 2020:

```CSV
PublicationDate,EditionNumber,Count
2020-03-03,044/2020,1
2020-03-06,047/2020,3
2020-03-09,048/2020,1
...
```

Days with no matching notices are omitted.

You can then use this CVS to create a chart in your favorite chart editor.

The query must be indicated using the [expert search syntax](https://ted.europa.eu/TED/misc/helpPage.do?helpPageId=expertSearch) used on the TED website. 

## Disclaimer

The TEDStats project is not affiliated with or endorsed by the European Commission or the Publications Office of the European Union.

The information on the TED web site (https://ted.europa.eu) is subject to a [disclaimer](https://ted.europa.eu/TED/misc/legalNotice.do#1.disclaimer), and a [copyright notice](https://ted.europa.eu/TED/misc/legalNotice.do#2.copyright).

If you have questions directly related to the data made available on the TED website, please [contact the TED team](https://ted.europa.eu/TED/misc/contact.do)
