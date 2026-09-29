// challenges-bin/cinema-ticket-pricing-system/Program.cs

int customerAge;
float ticketPrice;

Console.WriteLine("Enter your age: ");
customerAge = int.Parse(Console.ReadLine());

if (customerAge<5) {
  ticketPrice = 0;
} else if (customerAge<18) {
  ticketPrice = 5;
} else if (customerAge<60) {
  ticketPrice = 10;
} else {
  ticketPrice = 7;
}

Console.WriteLine(ticketPrice);