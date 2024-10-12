int emails = 20;

while (emails > 0)
{
  emails -= 1;
  System.Console.WriteLine("delete emails");
  System.Console.WriteLine($"rest emails {emails}");

  if (emails == 0)
  {
    System.Console.WriteLine("INBOX ZERO ACHIEVED!");
  }
}



