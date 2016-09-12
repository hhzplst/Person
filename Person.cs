using System;

namespace Person {
  public class Person {
    private static int LastIDAssigned = 0;
    private static Random randomNumber = new Random();
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int ID {get; set;}
    public Person(string firstName, string lastName) {
      FirstName = firstName;
      LastName = lastName;
      ID = SetID();
    }
    public string GetFullName() {
      return FirstName + LastName;
    }
    public override string ToString() {
      string result = "************************************************\n";
      result += String.Format("{0, -10} {1, 0} {2, 10} {3, 30}\n", "ID", "FIRSTNAME", "LASTNAME", "FULLNAME");
      result += "************************************************\n";
      result += String.Format("{0, -10} {1, 0} {2, 10} {3, 30}\n", ID, FirstName, LastName, GetFullName());
      return result;
    }
    public void PrintInfo() {
      Console.WriteLine(this.ToString());
    }
    private static int SetID() {
      int newID = randomNumber.Next(1000);
      while (newID == LastIDAssigned) {
        newID = randomNumber.Next(1000);
      }
      LastIDAssigned = newID;
      return newID;
    }
  }
}