// challenges-bin/branching-demo/Program.cs

int customerAge;
bool eligibleForFreeBuses;

Console.WriteLine("Enter your age: ");
customerAge = int.Parse(Console.ReadLine());

if (customerAge<22) {
  eligibleForFreeBuses = true;
  Console.WriteLine("You are eligible for free buses, under Green Party policy!");
} else {
  eligibleForFreeBuses = false;
  Console.WriteLine("Sorry! You aren't eligible for free buses, under Green Party policy.");
}

