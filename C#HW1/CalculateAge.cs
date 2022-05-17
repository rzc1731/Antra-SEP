// See https://aka.ms/new-console-template for more information
var birthdate = "1996/12/16";

DateTime today = DateTime.Today.Date;

DateTime birth = Convert.ToDateTime(birthdate);

double totalDays = (today - birth).TotalDays;

Console.WriteLine(totalDays + " days old");

double daysToNextAnniversary = 10000 - (totalDays % 10000);

Console.WriteLine(daysToNextAnniversary + " until next 10000 day anniversary");

